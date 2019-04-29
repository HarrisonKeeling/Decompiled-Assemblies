using System;
using UnityEngine;
using UnityEngine.UI;

public class NewsButton : MonoBehaviour
{
	public int storyNumber;

	public NewsSource.Story story;

	public CanvasGroup canvasGroup;

	public Text text;

	public Text author;

	public RawImage image;

	private float randomness;

	public NewsButton()
	{
	}
}