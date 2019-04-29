using System;
using UnityEngine;

namespace Rust.Ai
{
	public sealed class WithinAttackRangeOfTargetEntity : BaseScorer
	{
		public WithinAttackRangeOfTargetEntity()
		{
		}

		public override float GetScore(BaseContext c)
		{
			if (c.AIAgent.AttackTarget == null)
			{
				return 0f;
			}
			if (Vector3.Distance(c.AIAgent.AttackPosition, c.AIAgent.AttackTarget.ClosestPoint(c.AIAgent.AttackPosition)) > c.AIAgent.GetAttackRange)
			{
				return 0f;
			}
			return 1f;
		}
	}
}