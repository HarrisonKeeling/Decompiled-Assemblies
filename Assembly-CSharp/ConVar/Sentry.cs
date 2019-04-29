using System;

namespace ConVar
{
	[Factory("sentry")]
	public class Sentry : ConsoleSystem
	{
		[ServerVar(Help="target everyone regardless of authorization")]
		public static bool targetall;

		[ServerVar(Help="how long until something is considered hostile after it attacked")]
		public static float hostileduration;

		static Sentry()
		{
			Sentry.targetall = false;
			Sentry.hostileduration = 120f;
		}

		public Sentry()
		{
		}
	}
}