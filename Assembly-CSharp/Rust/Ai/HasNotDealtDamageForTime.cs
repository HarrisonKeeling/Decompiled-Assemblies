using Apex.Serialization;
using System;

namespace Rust.Ai
{
	public sealed class HasNotDealtDamageForTime : BaseScorer
	{
		[ApexSerialization]
		public float ForSeconds = 10f;

		public HasNotDealtDamageForTime()
		{
		}

		public override float GetScore(BaseContext c)
		{
			if (float.IsInfinity(c.Entity.SecondsSinceDealtDamage) || float.IsNaN(c.Entity.SecondsSinceDealtDamage))
			{
				return 0f;
			}
			if (c.Entity.SecondsSinceDealtDamage <= this.ForSeconds)
			{
				return 0f;
			}
			return 1f;
		}
	}
}