using System;
using UnityEngine;

namespace Rust.Ai
{
	public class PositionInAttackRangeOfTarget : WeightedScorerBase<Vector3>
	{
		public PositionInAttackRangeOfTarget()
		{
		}

		public override float GetScore(BaseContext c, Vector3 position)
		{
			if (c.AIAgent.AttackTarget == null)
			{
				return 0f;
			}
			if (Vector3.Distance(position, c.AIAgent.AttackTargetMemory.Position) < c.AIAgent.GetAttackRange)
			{
				return 1f;
			}
			return 0f;
		}
	}
}