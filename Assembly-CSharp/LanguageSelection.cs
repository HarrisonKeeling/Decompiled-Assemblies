using System;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelection : MonoBehaviour, ILanguageChanged
{
	public GameObject languagePopup;

	public GameObject buttonContainer;

	public Image flagImage;

	public LanguageSelection()
	{
	}
}