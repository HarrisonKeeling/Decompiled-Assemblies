using System;

namespace ConVar
{
	[Factory("env")]
	public class Env : ConsoleSystem
	{
		[ServerVar]
		public static int day
		{
			get
			{
				if (TOD_Sky.Instance == null)
				{
					return 0;
				}
				return TOD_Sky.Instance.Cycle.Day;
			}
			set
			{
				if (TOD_Sky.Instance == null)
				{
					return;
				}
				TOD_Sky.Instance.Cycle.Day = value;
			}
		}

		[ServerVar]
		public static int month
		{
			get
			{
				if (TOD_Sky.Instance == null)
				{
					return 0;
				}
				return TOD_Sky.Instance.Cycle.Month;
			}
			set
			{
				if (TOD_Sky.Instance == null)
				{
					return;
				}
				TOD_Sky.Instance.Cycle.Month = value;
			}
		}

		[ServerVar]
		public static bool progresstime
		{
			get
			{
				if (TOD_Sky.Instance == null)
				{
					return false;
				}
				return TOD_Sky.Instance.Components.Time.ProgressTime;
			}
			set
			{
				if (TOD_Sky.Instance == null)
				{
					return;
				}
				TOD_Sky.Instance.Components.Time.ProgressTime = value;
			}
		}

		[ServerVar]
		public static float time
		{
			get
			{
				if (TOD_Sky.Instance == null)
				{
					return 0f;
				}
				return TOD_Sky.Instance.Cycle.Hour;
			}
			set
			{
				if (TOD_Sky.Instance == null)
				{
					return;
				}
				TOD_Sky.Instance.Cycle.Hour = value;
			}
		}

		[ServerVar]
		public static int year
		{
			get
			{
				if (TOD_Sky.Instance == null)
				{
					return 0;
				}
				return TOD_Sky.Instance.Cycle.Year;
			}
			set
			{
				if (TOD_Sky.Instance == null)
				{
					return;
				}
				TOD_Sky.Instance.Cycle.Year = value;
			}
		}

		public Env()
		{
		}

		[ServerVar]
		public static void addtime(ConsoleSystem.Arg arg)
		{
			if (TOD_Sky.Instance == null)
			{
				return;
			}
			DateTime dateTime = TOD_Sky.Instance.Cycle.DateTime;
			dateTime = dateTime.Add(arg.GetTimeSpan(0));
			TOD_Sky.Instance.Cycle.DateTime = dateTime;
		}
	}
}