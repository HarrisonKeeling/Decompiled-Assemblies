using System;
using UnityEngine;

public class BoneInfoComponent : MonoBehaviour, IClientComponent
{
	[Header("Size Variation")]
	public Vector3 sizeVariation = Vector3.zero;

	public int sizeVariationSeed;

	public BoneInfoComponent()
	{
	}
}