using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectedItem : SingletonComponent<SelectedItem>, IInventoryChanged
{
	public Image icon;

	public Image iconSplitter;

	public TextMeshProUGUI title;

	public TextMeshProUGUI description;

	public GameObject splitPanel;

	public GameObject itemProtection;

	public GameObject menuOption;

	public GameObject optionsParent;

	public GameObject innerPanelContainer;

	public SelectedItem()
	{
	}
}