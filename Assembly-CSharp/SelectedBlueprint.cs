using System;
using UnityEngine;
using UnityEngine.UI;

public class SelectedBlueprint : SingletonComponent<SelectedBlueprint>, IInventoryChanged
{
	public ItemBlueprint blueprint;

	public InputField craftAmountText;

	public GameObject ingredientGrid;

	public IconSkinPicker skinPicker;

	public Image iconImage;

	public Text titleText;

	public Text descriptionText;

	public CanvasGroup CraftArea;

	public Button CraftButton;

	public Text CraftTime;

	public Text CraftAmount;

	public GameObject[] workbenchReqs;

	private ItemInformationPanel[] informationPanels;

	public static bool isOpen
	{
		get
		{
			if (SingletonComponent<SelectedBlueprint>.Instance == null)
			{
				return false;
			}
			return SingletonComponent<SelectedBlueprint>.Instance.blueprint != null;
		}
	}

	public SelectedBlueprint()
	{
	}
}