using System;
using UnityEngine;
using UnityEngine.UI;

public class UIBlueprints : ListComponent<UIBlueprints>
{
	public GameObjectRef buttonPrefab;

	public ScrollRect scrollRect;

	public InputField searchField;

	public GameObject listAvailable;

	public GameObject listLocked;

	public GameObject Categories;

	public UIBlueprints()
	{
	}
}