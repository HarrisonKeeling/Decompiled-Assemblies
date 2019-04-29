using Rust.Ai.HTN;
using Rust.Ai.HTN.Reasoning;
using Rust.Ai.HTN.ScientistAStar;
using System;
using System.Runtime.CompilerServices;

namespace Rust.Ai.HTN.ScientistAStar.Reasoners
{
	public class FrustrationReasoner : INpcReasoner
	{
		private float _lastFrustrationDecrementTime;

		public float LastTickTime
		{
			get;
			set;
		}

		public float TickFrequency
		{
			get;
			set;
		}

		public FrustrationReasoner()
		{
		}

		public void Tick(IHTNAgent npc, float deltaTime, float time)
		{
			ScientistAStarContext npcContext = npc.AiDomain.NpcContext as ScientistAStarContext;
			if (npcContext == null)
			{
				return;
			}
			if (npcContext.IsFact(Facts.Frustration) && time - this._lastFrustrationDecrementTime > 5f)
			{
				this._lastFrustrationDecrementTime = time;
				npcContext.IncrementFact(Facts.Frustration, -1, true, true, true);
			}
		}
	}
}