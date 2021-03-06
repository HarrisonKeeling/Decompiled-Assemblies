using Rust.Ai.HTN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace Rust.Ai.HTN.ScientistJunkpile
{
	[CreateAssetMenu(menuName="Rust/AI/Scientist Junkpile Definition")]
	public class ScientistJunkpileDefinition : BaseNpcDefinition
	{
		[Header("Aim")]
		public AnimationCurve MissFunction = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

		[Header("Equipment")]
		public PlayerInventoryProperties[] loadouts;

		public LootContainer.LootSpawnSlot[] Loot;

		[Header("Audio")]
		public Vector2 RadioEffectRepeatRange = new Vector2(10f, 15f);

		public GameObjectRef RadioEffect;

		public GameObjectRef DeathEffect;

		private bool _isRadioEffectRunning;

		public ScientistJunkpileDefinition()
		{
		}

		private IEnumerator EquipTool(HTNPlayer target)
		{
			yield return CoroutineEx.waitForSeconds(0.25f);
			if (target == null || target.IsDestroyed || target.IsDead() || target.IsWounded() || target.inventory == null || target.inventory.containerBelt == null)
			{
				yield break;
			}
			int num = 1;
			if (TOD_Sky.Instance != null && TOD_Sky.Instance.IsNight)
			{
				num = 2;
			}
			Item item = target.inventory.containerBelt.GetSlot(num);
			if (item == null)
			{
				item = target.inventory.containerBelt.GetSlot(0);
				if (item == null)
				{
					yield break;
				}
			}
			target.UpdateActiveItem(item.uid);
			yield return CoroutineEx.waitForSeconds(0.25f);
			ScientistJunkpileDomain aiDomain = target.AiDomain as ScientistJunkpileDomain;
			if (aiDomain)
			{
				if (item.info.category == ItemCategory.Weapon)
				{
					BaseEntity heldEntity = item.GetHeldEntity();
					if (heldEntity is BaseProjectile)
					{
						aiDomain.ScientistContext.SetFact(Facts.HeldItemType, ItemType.ProjectileWeapon, true, true, true);
						aiDomain.ReloadFirearm();
					}
					else if (heldEntity is BaseMelee)
					{
						aiDomain.ScientistContext.SetFact(Facts.HeldItemType, ItemType.MeleeWeapon, true, true, true);
					}
					else if (heldEntity is ThrownWeapon)
					{
						aiDomain.ScientistContext.SetFact(Facts.HeldItemType, ItemType.ThrowableWeapon, true, true, true);
					}
				}
				else if (item.info.category == ItemCategory.Medical)
				{
					aiDomain.ScientistContext.SetFact(Facts.HeldItemType, ItemType.HealingItem, true, true, true);
				}
				else if (item.info.category == ItemCategory.Tool)
				{
					HeldEntity heldEntity1 = target.GetHeldEntity();
					if (!(heldEntity1 != null) || !heldEntity1.LightsOn())
					{
						aiDomain.ScientistContext.SetFact(Facts.HeldItemType, ItemType.ResearchItem, true, true, true);
					}
					else
					{
						aiDomain.ScientistContext.SetFact(Facts.HeldItemType, ItemType.LightSourceItem, true, true, true);
					}
				}
			}
		}

		public override void Loadout(HTNPlayer target)
		{
			if (target == null || target.IsDestroyed || target.IsDead() || target.IsWounded() || target.inventory == null || target.inventory.containerBelt == null || target.inventory.containerMain == null || target.inventory.containerWear == null)
			{
				return;
			}
			if (this.loadouts == null || this.loadouts.Length == 0)
			{
				UnityEngine.Debug.LogWarning(string.Concat("Loadout for NPC ", base.name, " was empty."));
			}
			else
			{
				PlayerInventoryProperties playerInventoryProperty = this.loadouts[UnityEngine.Random.Range(0, (int)this.loadouts.Length)];
				if (playerInventoryProperty != null)
				{
					playerInventoryProperty.GiveToPlayer(target);
					target.StartCoroutine(this.EquipTool(target));
					return;
				}
			}
		}

		public override BaseCorpse OnCreateCorpse(HTNPlayer target)
		{
			int i;
			BaseCorpse baseCorpse;
			if (this.DeathEffect.isValid)
			{
				Effect.server.Run(this.DeathEffect.resourcePath, target, 0, Vector3.zero, Vector3.zero, null, false);
			}
			using (TimeWarning timeWarning = TimeWarning.New("Create corpse", 0.1f))
			{
				NPCPlayerCorpse navAgent = target.DropCorpse("assets/prefabs/npc/scientist/scientist_corpse.prefab") as NPCPlayerCorpse;
				if (navAgent)
				{
					if (target.AiDomain != null && target.AiDomain.NavAgent != null && target.AiDomain.NavAgent.isOnNavMesh)
					{
						navAgent.transform.position = navAgent.transform.position + (Vector3.down * target.AiDomain.NavAgent.baseOffset);
					}
					navAgent.SetLootableIn(2f);
					navAgent.SetFlag(BaseEntity.Flags.Reserved5, target.HasPlayerFlag(BasePlayer.PlayerFlags.DisplaySash), false, true);
					navAgent.SetFlag(BaseEntity.Flags.Reserved2, true, false, true);
					navAgent.TakeFrom(new ItemContainer[] { target.inventory.containerMain, target.inventory.containerWear, target.inventory.containerBelt });
					navAgent.playerName = target.displayName;
					navAgent.playerSteamID = target.userID;
					navAgent.Spawn();
					navAgent.TakeChildren(target);
					ItemContainer[] itemContainerArray = navAgent.containers;
					for (i = 0; i < (int)itemContainerArray.Length; i++)
					{
						itemContainerArray[i].Clear();
					}
					if (this.Loot.Length != 0)
					{
						LootContainer.LootSpawnSlot[] loot = this.Loot;
						for (i = 0; i < (int)loot.Length; i++)
						{
							LootContainer.LootSpawnSlot lootSpawnSlot = loot[i];
							for (int j = 0; j < lootSpawnSlot.numberToSpawn; j++)
							{
								if (UnityEngine.Random.Range(0f, 1f) <= lootSpawnSlot.probability)
								{
									lootSpawnSlot.definition.SpawnIntoContainer(navAgent.containers[0]);
								}
							}
						}
					}
				}
				baseCorpse = navAgent;
			}
			return baseCorpse;
		}

		private IEnumerator RadioChatter(HTNPlayer target)
		{
			ScientistJunkpileDefinition scientistJunkpileDefinition = null;
			while (scientistJunkpileDefinition._isRadioEffectRunning && target != null && target.transform != null && !target.IsDestroyed && !target.IsDead())
			{
				if (scientistJunkpileDefinition.RadioEffect.isValid)
				{
					Effect.server.Run(scientistJunkpileDefinition.RadioEffect.resourcePath, target, StringPool.Get("head"), Vector3.zero, Vector3.zero, null, false);
				}
				float single = UnityEngine.Random.Range(scientistJunkpileDefinition.RadioEffectRepeatRange.x, scientistJunkpileDefinition.RadioEffectRepeatRange.y + 1f);
				yield return CoroutineEx.waitForSeconds(single);
			}
		}

		public override void StartVoices(HTNPlayer target)
		{
			if (this._isRadioEffectRunning)
			{
				return;
			}
			this._isRadioEffectRunning = true;
			target.StartCoroutine(this.RadioChatter(target));
		}

		public override void StopVoices(HTNPlayer target)
		{
			if (!this._isRadioEffectRunning)
			{
				return;
			}
			this._isRadioEffectRunning = false;
		}
	}
}