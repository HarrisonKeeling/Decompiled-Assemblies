using System;
using UnityEngine;
using UnityEngine.UI;

public class GameTip : SingletonComponent<GameTip>
{
	public CanvasGroup canvasGroup;

	public Text text;

	public GameTip()
	{
	}
}