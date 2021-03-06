using System;
using UnityEngine;

namespace ConVar
{
	[Factory("physics")]
	public class Physics : ConsoleSystem
	{
		private const float baseGravity = -9.81f;

		[ServerVar(Help="The collision detection mode that dropped items and corpses should use")]
		public static int droppedmode;

		[ServerVar(Help="Send effects to clients when physics objects collide")]
		public static bool sendeffects;

		[ServerVar]
		public static float bouncethreshold
		{
			get
			{
				return UnityEngine.Physics.bounceThreshold;
			}
			set
			{
				UnityEngine.Physics.bounceThreshold = value;
			}
		}

		[ServerVar(Help="Gravity multiplier")]
		public static float gravity
		{
			get
			{
				return UnityEngine.Physics.gravity.y / -9.81f;
			}
			set
			{
				UnityEngine.Physics.gravity = new Vector3(0f, value * -9.81f, 0f);
			}
		}

		[ClientVar]
		[ServerVar(Help="The slowest physics steps will operate")]
		public static float minsteps
		{
			get
			{
				return 1f / UnityEngine.Time.maximumDeltaTime;
			}
			set
			{
				if (value < 1f)
				{
					value = 1f;
				}
				if (value > 60f)
				{
					value = 60f;
				}
				UnityEngine.Time.maximumDeltaTime = 1f / value;
			}
		}

		[ServerVar]
		public static float sleepthreshold
		{
			get
			{
				return UnityEngine.Physics.sleepThreshold;
			}
			set
			{
				UnityEngine.Physics.sleepThreshold = value;
			}
		}

		[ServerVar(Help="The default solver iteration count permitted for any rigid bodies (default 7). Must be positive")]
		public static int solveriterationcount
		{
			get
			{
				return UnityEngine.Physics.defaultSolverIterations;
			}
			set
			{
				UnityEngine.Physics.defaultSolverIterations = value;
			}
		}

		[ClientVar]
		[ServerVar(Help="The amount of physics steps per second")]
		public static float steps
		{
			get
			{
				return 1f / UnityEngine.Time.fixedDeltaTime;
			}
			set
			{
				if (value < 10f)
				{
					value = 10f;
				}
				if (value > 60f)
				{
					value = 60f;
				}
				UnityEngine.Time.fixedDeltaTime = 1f / value;
			}
		}

		static Physics()
		{
			ConVar.Physics.droppedmode = 2;
			ConVar.Physics.sendeffects = true;
		}

		public Physics()
		{
		}

		internal static void ApplyDropped(Rigidbody rigidBody)
		{
			if (ConVar.Physics.droppedmode <= 0)
			{
				rigidBody.collisionDetectionMode = CollisionDetectionMode.Discrete;
			}
			if (ConVar.Physics.droppedmode == 1)
			{
				rigidBody.collisionDetectionMode = CollisionDetectionMode.Continuous;
			}
			if (ConVar.Physics.droppedmode == 2)
			{
				rigidBody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
			}
			if (ConVar.Physics.droppedmode >= 3)
			{
				rigidBody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
			}
		}
	}
}