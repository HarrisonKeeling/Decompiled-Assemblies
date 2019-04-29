using System;
using UnityEngine;
using UnityEngine.UI;

public class VirtualItemIcon : MonoBehaviour
{
	public ItemDefinition itemDef;

	public int itemAmount;

	public bool asBlueprint;

	public Image iconImage;

	public Image bpUnderlay;

	public Text amountText;

	public CanvasGroup iconContents;

	public CanvasGroup conditionObject;

	public Image conditionFill;

	public Image maxConditionFill;

	public Image cornerIcon;

	public VirtualItemIcon()
	{
	}
}