using System;
using UnityEngine;
using UnityEngine.UI;

public class VitalInfo : MonoBehaviour, IClientComponent
{
	public VitalInfo.Vital VitalType;

	public Animator animator;

	public Text text;

	public VitalInfo()
	{
	}

	public enum Vital
	{
		BuildingBlocked,
		CanBuild,
		Crafting,
		CraftLevel1,
		CraftLevel2,
		CraftLevel3,
		DecayProtected,
		Decaying,
		SafeZone
	}
}