using System;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFlare : BaseMonoBehaviour, IClientComponent
{
	public bool timeShimmer;

	public bool positionalShimmer;

	public bool rotate;

	public float fadeSpeed = 35f;

	public Collider checkCollider;

	public float maxVisibleDistance = 30f;

	public bool lightScaled;

	public bool alignToCameraViaScript;

	protected float tickRate = 0.33f;

	private Vector3 fullSize;

	public bool faceCameraPos = true;

	public bool billboardViaShader;

	private float artificialLightExposure;

	private float privateRand;

	private List<BasePlayer> players;

	private Renderer myRenderer;

	private static MaterialPropertyBlock block;

	public float dotMin = -1f;

	public float dotMax = -1f;

	public SimpleFlare()
	{
	}
}