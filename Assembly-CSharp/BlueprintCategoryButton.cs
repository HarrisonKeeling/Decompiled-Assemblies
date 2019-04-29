using System;
using UnityEngine;
using UnityEngine.UI;

public class BlueprintCategoryButton : MonoBehaviour, IInventoryChanged
{
	public Text amountLabel;

	public ItemCategory Category;

	public GameObject BackgroundHighlight;

	public SoundDefinition clickSound;

	public SoundDefinition hoverSound;

	public BlueprintCategoryButton()
	{
	}
}