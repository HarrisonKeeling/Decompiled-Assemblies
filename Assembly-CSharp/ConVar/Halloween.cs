using System;

namespace ConVar
{
	[Factory("halloween")]
	public class Halloween : ConsoleSystem
	{
		[ServerVar]
		public static bool enabled;

		[ServerVar(Help="Population active on the server, per square km")]
		public static float murdererpopulation;

		[ServerVar(Help="Population active on the server, per square km")]
		public static float scarecrowpopulation;

		[ServerVar(Help="Scarecrows can throw beancans (Default: true).")]
		public static bool scarecrows_throw_beancans;

		[ServerVar(Help="The delay globally on a server between each time a scarecrow throws a beancan (Default: 8 seconds).")]
		public static float scarecrow_throw_beancan_global_delay;

		[ServerVar(Help="Modified damage from beancan explosion vs players (Default: 0.1).")]
		public static float scarecrow_beancan_vs_player_dmg_modifier;

		[ServerVar(Help="Modifier to how much damage scarecrows take to the body. (Default: 0.25)")]
		public static float scarecrow_body_dmg_modifier;

		[ServerVar(Help="Stopping distance for destinations set while chasing a target (Default: 0.5)")]
		public static float scarecrow_chase_stopping_distance;

		static Halloween()
		{
			Halloween.enabled = false;
			Halloween.murdererpopulation = 0f;
			Halloween.scarecrowpopulation = 0f;
			Halloween.scarecrows_throw_beancans = true;
			Halloween.scarecrow_throw_beancan_global_delay = 8f;
			Halloween.scarecrow_beancan_vs_player_dmg_modifier = 0.1f;
			Halloween.scarecrow_body_dmg_modifier = 0.25f;
			Halloween.scarecrow_chase_stopping_distance = 0.5f;
		}

		public Halloween()
		{
		}
	}
}