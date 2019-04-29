using Apex.Serialization;
using System;
using UnityEngine;

namespace Rust.Ai
{
	public class LineOfSightToTarget : WeightedScorerBase<Vector3>
	{
		[ApexSerialization]
		private LineOfSightToTarget.CoverType Cover;

		public LineOfSightToTarget()
		{
		}

		public override float GetScore(BaseContext c, Vector3 position)
		{
			if (c.AIAgent.AttackTarget == null)
			{
				return 0f;
			}
			if (this.Cover == LineOfSightToTarget.CoverType.Full)
			{
				if (!c.AIAgent.AttackTarget.IsVisible(position + new Vector3(0f, 1.8f, 0f), Single.PositiveInfinity))
				{
					return 0f;
				}
				return 1f;
			}
			if (!c.AIAgent.AttackTarget.IsVisible(position + new Vector3(0f, 0.9f, 0f), Single.PositiveInfinity))
			{
				return 0f;
			}
			return 1f;
		}

		public enum CoverType
		{
			Full,
			Partial
		}
	}
}