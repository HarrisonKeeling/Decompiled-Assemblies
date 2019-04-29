using System;
using UnityEngine;
using UnityEngine.AI;

namespace Rust.Ai
{
	public class PreventPickingInvalidPositionAgain : WeightedScorerBase<Vector3>
	{
		public PreventPickingInvalidPositionAgain()
		{
		}

		public override float GetScore(BaseContext c, Vector3 option)
		{
			if (c.AIAgent.IsNavRunning())
			{
				NavMeshAgent getNavAgent = c.AIAgent.GetNavAgent;
				if (getNavAgent != null && (!getNavAgent.hasPath || getNavAgent.isPathStale || getNavAgent.pathStatus == NavMeshPathStatus.PathPartial || getNavAgent.pathStatus == NavMeshPathStatus.PathInvalid) && (c.lastSampledPosition - option).sqrMagnitude < 0.1f)
				{
					return 0f;
				}
			}
			return 1f;
		}
	}
}