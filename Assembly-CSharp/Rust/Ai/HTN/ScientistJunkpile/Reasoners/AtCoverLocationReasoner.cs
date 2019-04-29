using Rust.Ai;
using Rust.Ai.HTN;
using Rust.Ai.HTN.Reasoning;
using Rust.Ai.HTN.ScientistJunkpile;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Rust.Ai.HTN.ScientistJunkpile.Reasoners
{
	public class AtCoverLocationReasoner : INpcReasoner
	{
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

		public AtCoverLocationReasoner()
		{
		}

		public void Tick(IHTNAgent npc, float deltaTime, float time)
		{
			ScientistJunkpileContext npcContext = npc.AiDomain.NpcContext as ScientistJunkpileContext;
			if (npcContext == null)
			{
				return;
			}
			if (npcContext.ReservedCoverPoint == null)
			{
				npcContext.SetFact(Facts.AtLocationCover, false, true, true, true);
				npcContext.SetFact(Facts.CoverState, CoverState.None, true, true, true);
				return;
			}
			if ((npcContext.ReservedCoverPoint.Position - npcContext.Body.transform.position).sqrMagnitude >= 1f)
			{
				npcContext.SetFact(Facts.AtLocationCover, false, true, true, true);
				npcContext.SetFact(Facts.CoverState, CoverState.None, true, true, true);
				return;
			}
			npcContext.SetFact(Facts.AtLocationCover, true, true, true, true);
			npcContext.SetFact(Facts.CoverState, (npcContext.ReservedCoverPoint.NormalCoverType == CoverPoint.CoverType.Partial ? CoverState.Partial : CoverState.Full), true, true, true);
		}
	}
}