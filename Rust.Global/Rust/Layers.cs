using System;

namespace Rust
{
	public static class Layers
	{
		public const int Terrain = 8388608;

		public const int World = 65536;

		public const int Ragdolls = 512;

		public const int Construction = 2097152;

		public const int ConstructionSocket = 4194304;

		public const int Craters = 1;

		public const int GameTrace = 16384;

		public const int Trigger = 262144;

		public const int RainFall = 1101070337;

		public const int Deploy = 1235288065;

		public const int DefaultDeployVolumeCheck = 537001984;

		public const int BuildLineOfSightCheck = 2097152;

		public const int ProjectileLineOfSightCheck = 2162688;

		public const int MeleeLineOfSightCheck = 2162688;

		public const int EyeLineOfSightCheck = 2162688;

		public const int EntityLineOfSightCheck = 1218519041;

		public const int PlayerBuildings = 18874624;

		public const int PlannerPlacement = 161546496;

		public const int Solid = 1218652417;

		public const int VisCulling = 10551297;

		public const int AltitudeCheck = 1218511105;

		public const int HABGroundEffect = 1218511105;

		public const int AILineOfSight = 1218519297;

		public const int DismountCheck = 1486946561;

		public const int AIPlacement = 278986753;

		public static class Client
		{
			public const int Melee = 1269916417;

			public const int Bullet = 1269916433;

			public const int PlayerUse = 229731073;

			public const int PlayerMovement = 1537286401;

			public const int PlayerStepDetection = 455155969;

			public const int Footstep = 10551297;
		}

		public static class Mask
		{
			public const int Default = 1;

			public const int TransparentFX = 2;

			public const int Ignore_Raycast = 4;

			public const int Reserved1 = 8;

			public const int Water = 16;

			public const int UI = 32;

			public const int Reserved2 = 64;

			public const int Reserved3 = 128;

			public const int Deployed = 256;

			public const int Ragdoll = 512;

			public const int Invisible = 1024;

			public const int AI = 2048;

			public const int Player_Movement = 4096;

			public const int Vehicle_Movement = 8192;

			public const int Game_Trace = 16384;

			public const int Reflections = 32768;

			public const int World = 65536;

			public const int Player_Server = 131072;

			public const int Trigger = 262144;

			public const int Player_Model_Rendering = 524288;

			public const int Physics_Projectile = 1048576;

			public const int Construction = 2097152;

			public const int Construction_Socket = 4194304;

			public const int Terrain = 8388608;

			public const int Transparent = 16777216;

			public const int Clutter = 33554432;

			public const int Debris = 67108864;

			public const int Vehicle_Large = 134217728;

			public const int Prevent_Movement = 268435456;

			public const int Prevent_Building = 536870912;

			public const int Tree = 1073741824;

			public const int Unused2 = -2147483648;
		}

		public static class Server
		{
			public const int Vehicles = 8192;

			public const int Players = 131072;

			public const int NPCs = 2048;

			public const int Buildings = 2097152;

			public const int Bullet = 1219701521;

			public const int Projectile = 1236478737;

			public const int Deployed = 256;

			public const int Stability = 2097408;

			public const int Decay = 2097408;

			public const int PlayerMovement = 429990145;

			public const int PlayerGrounded = 1503731969;

			public const int GroundWatch = 27328512;

			public const int Targets = 133120;
		}
	}
}