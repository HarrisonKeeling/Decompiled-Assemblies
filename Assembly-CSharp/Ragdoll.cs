using System;
using UnityEngine;

public class Ragdoll : BaseMonoBehaviour
{
	public Transform eyeTransform;

	public Transform centerBone;

	public Rigidbody primaryBody;

	public PhysicMaterial physicMaterial;

	public SpringJoint corpseJoint;

	public GameObject GibEffect;

	public Ragdoll()
	{
	}
}