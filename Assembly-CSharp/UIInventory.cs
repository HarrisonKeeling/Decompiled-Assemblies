using System;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : SingletonComponent<UIInventory>
{
	public Text PlayerName;

	public static bool isOpen;

	public static float LastOpened;

	public VerticalLayoutGroup rightContents;

	public GameObject QuickCraft;

	public UIInventory()
	{
	}
}