using System;

namespace Rust.Ai
{
	public class CanAffordAttack : BaseScorer
	{
		public CanAffordAttack()
		{
		}

		public override float GetScore(BaseContext c)
		{
			if (c.AIAgent.GetStamina < c.AIAgent.GetAttackCost)
			{
				return 0f;
			}
			return 1f;
		}
	}
}