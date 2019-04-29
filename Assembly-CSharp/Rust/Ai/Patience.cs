using System;

namespace Rust.Ai
{
	public sealed class Patience : BaseScorer
	{
		public Patience()
		{
		}

		public override float GetScore(BaseContext c)
		{
			return c.AIAgent.GetStats.Tolerance;
		}
	}
}