using System;
using UnityEngine;

namespace Rust.Ai
{
	public sealed class AggressionRangeFromTargetEntity : BaseScorer
	{
		public AggressionRangeFromTargetEntity()
		{
		}

		public override float GetScore(BaseContext c)
		{
			if (c.AIAgent.AttackTarget == null || Mathf.Approximately(c.AIAgent.GetStats.AggressionRange, 0f))
			{
				return 0f;
			}
			return Vector3.Distance(c.AIAgent.AttackPosition, c.AIAgent.AttackTargetMemory.Position) / c.AIAgent.GetStats.AggressionRange;
		}
	}
}