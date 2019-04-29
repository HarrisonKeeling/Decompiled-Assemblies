using System;

namespace Rust.Ai.HTN
{
	public struct NpcPlayerInfo
	{
		public BasePlayer Player;

		public float Time;

		public float SqrDistance;

		public float ForwardDotDir;

		public bool BodyVisible;

		public bool HeadVisible;

		public float AudibleScore;

		public float VisibilityScore;
	}
}