using System;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleUI : SingletonComponent<ConsoleUI>
{
	public Text text;

	public InputField outputField;

	public InputField inputField;

	public GameObject AutocompleteDropDown;

	public GameObject ItemTemplate;

	public Color errorColor;

	public Color warningColor;

	public Color inputColor;

	public ConsoleUI()
	{
	}
}