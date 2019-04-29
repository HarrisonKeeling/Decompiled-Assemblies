using System;
using UnityEngine;

public class LightGroupAtTime : FacepunchBehaviour
{
	public AnimationCurve IntensityScaleOverTime = new AnimationCurve()
	{
		keys = new Keyframe[] { new Keyframe(0f, 1f), new Keyframe(8f, 0f), new Keyframe(12f, 0f), new Keyframe(19f, 1f), new Keyframe(24f, 1f) }
	};

	public Transform SearchRoot;

	public LightGroupAtTime()
	{
	}
}