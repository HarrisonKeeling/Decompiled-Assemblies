using System;

namespace Rust.Ai
{
	public sealed class WantsToAttackEntity : WeightedScorerBase<BaseEntity>
	{
		public WantsToAttackEntity()
		{
		}

		public override float GetScore(BaseContext c, BaseEntity target)
		{
			return c.AIAgent.GetWantsToAttack(target);
		}
	}
}