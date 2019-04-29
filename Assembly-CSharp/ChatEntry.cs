using System;
using UnityEngine;
using UnityEngine.UI;

public class ChatEntry : MonoBehaviour
{
	public Text text;

	public RawImage avatar;

	public CanvasGroup canvasGroup;

	public float lifeStarted;

	public ulong steamid;

	public ChatEntry()
	{
	}
}