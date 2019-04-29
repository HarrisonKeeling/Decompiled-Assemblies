using System;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(CommandBufferManager))]
[RequireComponent(typeof(Camera))]
public class DeferredExtension : MonoBehaviour
{
	public ExtendGBufferParams extendGBuffer = ExtendGBufferParams.Default;

	public SubsurfaceScatteringParams subsurfaceScattering = SubsurfaceScatteringParams.Default;

	public Texture2D blueNoise;

	public float depthScale = 100f;

	public bool debug;

	public DeferredExtension()
	{
	}
}