using ConVar;
using Rust;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rust.Ai.HTN.ScientistAStar
{
	public class ScientistAStarSpawner : MonoBehaviour, IServerComponent
	{
		public BasePath Path;

		public GameObjectRef ScientistAStarPrefab;

		[NonSerialized]
		public List<ScientistAStarDomain> Spawned = new List<ScientistAStarDomain>();

		[NonSerialized]
		public BaseSpawnPoint[] SpawnPoints;

		public int MaxPopulation = 1;

		public bool InitialSpawn;

		public float MinRespawnTimeMinutes = 20f;

		public float MaxRespawnTimeMinutes = 20f;

		private bool pendingRespawn;

		private bool _lastInvokeWasNoSpawn;

		public ScientistAStarSpawner()
		{
		}

		private void Awake()
		{
			this.SpawnPoints = base.GetComponentsInChildren<BaseSpawnPoint>();
		}

		public void CheckIfRespawnNeeded()
		{
			if (!ConVar.AI.npc_spawn_on_cargo_ship)
			{
				this._lastInvokeWasNoSpawn = true;
				return;
			}
			if (this._lastInvokeWasNoSpawn)
			{
				this.DoRespawn();
				this._lastInvokeWasNoSpawn = false;
				return;
			}
			if (!this.pendingRespawn && (this.Spawned == null || this.Spawned.Count == 0 || this.IsAllSpawnedDead()))
			{
				this.ScheduleRespawn();
				this._lastInvokeWasNoSpawn = false;
			}
		}

		public void DelayedStart()
		{
			if (this.InitialSpawn && ConVar.AI.npc_spawn_on_cargo_ship)
			{
				this.DoRespawn();
			}
			base.InvokeRepeating("CheckIfRespawnNeeded", 0f, 5f);
		}

		public void DoRespawn()
		{
			if (!Rust.Application.isLoading && !Rust.Application.isLoadingSave)
			{
				this.SpawnScientist();
			}
			this.pendingRespawn = false;
		}

		private BaseSpawnPoint GetSpawnPoint(out Vector3 pos, out Quaternion rot)
		{
			BaseSpawnPoint spawnPoints = null;
			pos = Vector3.zero;
			rot = Quaternion.identity;
			int num = UnityEngine.Random.Range(0, (int)this.SpawnPoints.Length);
			for (int i = 0; i < (int)this.SpawnPoints.Length; i++)
			{
				spawnPoints = this.SpawnPoints[(num + i) % (int)this.SpawnPoints.Length];
				if (spawnPoints && spawnPoints.gameObject.activeSelf)
				{
					break;
				}
			}
			if (spawnPoints)
			{
				spawnPoints.GetLocation(out pos, out rot);
			}
			return spawnPoints;
		}

		private bool IsAllSpawnedDead()
		{
			for (int i = 0; i < this.Spawned.Count; i++)
			{
				ScientistAStarDomain item = this.Spawned[i];
				if (!(item == null) && !(item.transform == null) && item.ScientistContext != null && !(item.ScientistContext.Body == null) && !item.ScientistContext.Body.IsDestroyed && !item.ScientistContext.Body.IsDead())
				{
					return false;
				}
				this.Spawned.RemoveAt(i);
				i--;
			}
			return true;
		}

		public void ScheduleRespawn()
		{
			base.CancelInvoke("DoRespawn");
			base.Invoke("DoRespawn", UnityEngine.Random.Range(this.MinRespawnTimeMinutes, this.MaxRespawnTimeMinutes) * 60f);
			this.pendingRespawn = true;
		}

		public void SpawnScientist()
		{
			Vector3 vector3;
			Quaternion quaternion;
			if (this.Spawned == null || this.Spawned.Count >= this.MaxPopulation)
			{
				Debug.LogWarning("Attempted to spawn an AStar Scientist, but the spawner was full!");
				return;
			}
			if (!ConVar.AI.npc_enable)
			{
				return;
			}
			int maxPopulation = this.MaxPopulation - this.Spawned.Count;
			for (int i = 0; i < maxPopulation; i++)
			{
				if (this.GetSpawnPoint(out vector3, out quaternion) != null)
				{
					BaseEntity baseEntity = GameManager.server.CreateEntity(this.ScientistAStarPrefab.resourcePath, vector3, quaternion, false);
					ScientistAStarDomain component = baseEntity.GetComponent<ScientistAStarDomain>();
					if (!component)
					{
						baseEntity.Kill(BaseNetworkable.DestroyMode.None);
						return;
					}
					baseEntity.enableSaving = false;
					baseEntity.gameObject.AwakeFromInstantiate();
					baseEntity.Spawn();
					component.InstallPath(this.Path);
					this.Spawned.Add(component);
				}
			}
		}

		public void Start()
		{
			base.Invoke("DelayedStart", 3f);
		}
	}
}