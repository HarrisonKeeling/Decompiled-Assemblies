using System;
using UnityEngine;

public class PlayerModelSkin : MonoBehaviour
{
	public PlayerModelSkin()
	{
	}

	public void Setup(SkinSetCollection skin, float materialNum, float meshNum)
	{
		SkinSet skinSet = skin.Get(meshNum);
		if (skinSet == null)
		{
			Debug.LogError("Skin.Get returned a NULL skin");
		}
		skinSet.Process(base.gameObject, materialNum);
	}
}