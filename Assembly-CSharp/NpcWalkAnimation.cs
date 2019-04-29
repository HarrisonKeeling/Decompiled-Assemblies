using System;
using UnityEngine;

public class NpcWalkAnimation : MonoBehaviour, IClientComponent
{
	public Vector3 HipFudge = new Vector3(-90f, 0f, 90f);

	public BaseNpc Npc;

	public UnityEngine.Animator Animator;

	public Transform HipBone;

	public Transform LookBone;

	public bool UpdateWalkSpeed = true;

	public bool UpdateFacingDirection = true;

	public bool UpdateGroundNormal = true;

	public Transform alignmentRoot;

	public bool LaggyAss = true;

	public bool LookAtTarget;

	public float MaxLaggyAssRotation = 70f;

	public float MaxWalkAnimSpeed = 25f;

	public bool UseDirectionBlending;

	public NpcWalkAnimation()
	{
	}
}