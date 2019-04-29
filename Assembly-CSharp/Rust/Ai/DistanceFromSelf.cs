using Apex.Serialization;
using System;
using UnityEngine;

namespace Rust.Ai
{
	public class DistanceFromSelf : WeightedScorerBase<Vector3>
	{
		[ApexSerialization]
		public float Range = 20f;

		public DistanceFromSelf()
		{
		}

		public override float GetScore(BaseContext c, Vector3 position)
		{
			return Mathf.Clamp(Vector3.Distance(position, c.Position), 0f, this.Range) / this.Range;
		}
	}
}