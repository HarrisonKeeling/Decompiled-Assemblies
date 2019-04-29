using System;
using UnityEngine;
using UnityEngine.UI;

public class UIChat : SingletonComponent<UIChat>
{
	public GameObject inputArea;

	public GameObject chatArea;

	public InputField inputField;

	public ScrollRect scrollRect;

	public CanvasGroup canvasGroup;

	public GameObjectRef chatItemPlayer;

	public static bool isOpen;

	static UIChat()
	{
	}

	public UIChat()
	{
	}
}