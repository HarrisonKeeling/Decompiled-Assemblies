using System;
using UnityEngine;

namespace Rust.Ai
{
	public sealed class CanReachBeforeTarget : WeightedScorerBase<Vector3>
	{
		public CanReachBeforeTarget()
		{
		}

		public override float GetScore(BaseContext c, Vector3 point)
		{
			if (c.AIAgent.AttackTarget == null)
			{
				return 0f;
			}
			float single = Vector3.Distance(c.AIAgent.AttackTargetMemory.Position, point);
			if (Vector3.Distance(c.Position, point) >= single)
			{
				return 0f;
			}
			return 1f;
		}
	}
}