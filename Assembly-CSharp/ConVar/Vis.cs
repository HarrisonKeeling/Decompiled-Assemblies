using System;

namespace ConVar
{
	[Factory("vis")]
	public class Vis : ConsoleSystem
	{
		[ClientVar]
		[Help("Turns on debug display of lerp")]
		public static bool lerp;

		[Help("Turns on debug display of damages")]
		[ServerVar]
		public static bool damage;

		[ClientVar]
		[Help("Turns on debug display of attacks")]
		[ServerVar]
		public static bool attack;

		[ClientVar]
		[Help("Turns on debug display of protection")]
		[ServerVar]
		public static bool protection;

		[Help("Turns on debug display of weakspots")]
		[ServerVar]
		public static bool weakspots;

		[Help("Show trigger entries")]
		[ServerVar]
		public static bool triggers;

		[Help("Turns on debug display of hitboxes")]
		[ServerVar]
		public static bool hitboxes;

		[Help("Turns on debug display of line of sight checks")]
		[ServerVar]
		public static bool lineofsight;

		[Help("Turns on debug display of senses, which are received by Ai")]
		[ServerVar]
		public static bool sense;

		static Vis()
		{
		}

		public Vis()
		{
		}
	}
}