using System;
using UnityEngine;

public class EmissionToggle : MonoBehaviour, IClientComponent
{
	private Color emissionColor;

	public Renderer[] targetRenderers;

	public int materialIndex = -1;

	private static MaterialPropertyBlock block;

	public EmissionToggle()
	{
	}
}