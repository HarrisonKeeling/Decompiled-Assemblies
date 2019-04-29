using System;
using UnityEngine;
using UnityEngine.UI;

public class UIDeathScreen : SingletonComponent<UIDeathScreen>, IUIScreen
{
	public GameObject sleepingBagIconPrefab;

	public GameObject sleepingBagContainer;

	public LifeInfographic previousLifeInfographic;

	public Animator screenAnimator;

	public bool fadeIn;

	public Button ReportCheatButton;

	public UIDeathScreen()
	{
	}
}