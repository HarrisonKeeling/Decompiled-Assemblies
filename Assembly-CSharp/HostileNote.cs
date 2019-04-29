using System;
using UnityEngine;
using UnityEngine.UI;

public class HostileNote : MonoBehaviour, IClientComponent
{
	public CanvasGroup warnGroup;

	public CanvasGroup @group;

	public CanvasGroup timerGroup;

	public Text timerText;

	public static float unhostileTime;

	public static float weaponDrawnDuration;

	public Color warnColor;

	public Color hostileColor;

	static HostileNote()
	{
	}

	public HostileNote()
	{
	}
}