using System;
using UnityEngine;
using UnityEngine.UI;

public class BlueprintButton : MonoBehaviour, IClientComponent, IInventoryChanged
{
	public Text name;

	public Text subtitle;

	public Image image;

	public Button button;

	public CanvasGroup @group;

	public GameObject newNotification;

	public string gotColor = "#ffffff";

	public string notGotColor = "#ff0000";

	public float craftableFraction;

	public GameObject lockedOverlay;

	[Header("Locked")]
	public CanvasGroup LockedGroup;

	public Text LockedPrice;

	public Image LockedImageBackground;

	public Color LockedCannotUnlockColor;

	public Color LockedCanUnlockColor;

	[Header("Unlock Level")]
	public GameObject LockedLevel;

	public BlueprintButton()
	{
	}
}