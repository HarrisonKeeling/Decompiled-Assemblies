using Rust;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ProtectionValue : MonoBehaviour, IClothingChanged
{
	public CanvasGroup @group;

	public Text text;

	public DamageType damageType;

	public bool selectedItem;

	public bool displayBaseProtection;

	public ProtectionValue()
	{
	}
}