using Rust.Ai.HTN;
using Rust.Ai.HTN.Reasoning;
using Rust.Ai.HTN.ScientistJunkpile;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Rust.Ai.HTN.ScientistJunkpile.Reasoners
{
	public class FireTacticReasoner : INpcReasoner
	{
		public float LastTickTime
		{
			get;
			set;
		}

		public float TickFrequency
		{
			get;
			set;
		}

		public FireTacticReasoner()
		{
		}

		public void Tick(IHTNAgent npc, float deltaTime, float time)
		{
			ScientistJunkpileContext npcContext = npc.AiDomain.NpcContext as ScientistJunkpileContext;
			if (npcContext == null)
			{
				return;
			}
			HTNPlayer hTNPlayer = npc as HTNPlayer;
			if (hTNPlayer == null)
			{
				return;
			}
			FireTactic fireTactic = FireTactic.Single;
			AttackEntity heldEntity = hTNPlayer.GetHeldEntity() as AttackEntity;
			if (heldEntity)
			{
				BaseProjectile baseProjectile = heldEntity as BaseProjectile;
				float sqrDistance = Single.MaxValue;
				if (npcContext.PrimaryEnemyPlayerInLineOfSight.Player != null)
				{
					sqrDistance = npcContext.PrimaryEnemyPlayerInLineOfSight.SqrDistance;
					if (Mathf.Approximately(sqrDistance, 0f))
					{
						sqrDistance = Single.MaxValue;
					}
				}
				else if (npcContext.Memory.PrimaryKnownAnimal.Animal != null)
				{
					sqrDistance = npcContext.Memory.PrimaryKnownAnimal.SqrDistance;
					if (Mathf.Approximately(sqrDistance, 0f))
					{
						sqrDistance = Single.MaxValue;
					}
				}
				if (heldEntity.attackLengthMin < 0f || sqrDistance > npcContext.Body.AiDefinition.Engagement.SqrCloseRangeFirearm(baseProjectile))
				{
					fireTactic = (heldEntity.attackLengthMin < 0f || sqrDistance > npcContext.Body.AiDefinition.Engagement.SqrMediumRangeFirearm(baseProjectile) ? FireTactic.Single : FireTactic.Burst);
				}
				else
				{
					fireTactic = FireTactic.FullAuto;
				}
			}
			npcContext.SetFact(Facts.FireTactic, fireTactic, true, true, true);
		}
	}
}