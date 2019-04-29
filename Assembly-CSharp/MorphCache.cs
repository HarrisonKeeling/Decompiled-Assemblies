using System;
using UnityEngine;

public class MorphCache : MonoBehaviour
{
	public bool fallback;

	public int blendShape = -1;

	[Range(0f, 1f)]
	public float[] blendWeights;

	public MorphCache()
	{
	}
}