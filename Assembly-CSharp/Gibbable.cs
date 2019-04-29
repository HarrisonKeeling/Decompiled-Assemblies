using System;
using UnityEngine;

public class Gibbable : MonoBehaviour, IClientComponent
{
	public GameObject gibSource;

	public GameObject materialSource;

	public bool copyMaterialBlock = true;

	public PhysicMaterial physicsMaterial;

	public GameObjectRef fxPrefab;

	public bool spawnFxPrefab = true;

	[Tooltip("If enabled, gibs will spawn even though we've hit a gib limit")]
	public bool important;

	public float explodeScale;

	public Gibbable()
	{
	}
}