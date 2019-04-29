using System;

namespace UnityEngine
{
	public static class DebugEx
	{
		public static void Log(object message, StackTraceLogType stacktrace)
		{
			StackTraceLogType stackTraceLogType = Application.GetStackTraceLogType(LogType.Log);
			Application.SetStackTraceLogType(LogType.Log, stacktrace);
			Debug.Log(message);
			Application.SetStackTraceLogType(LogType.Log, stackTraceLogType);
		}

		public static void Log(object message, UnityEngine.Object context, StackTraceLogType stacktrace)
		{
			StackTraceLogType stackTraceLogType = Application.GetStackTraceLogType(LogType.Log);
			Application.SetStackTraceLogType(LogType.Log, stacktrace);
			Debug.Log(message, context);
			Application.SetStackTraceLogType(LogType.Log, stackTraceLogType);
		}
	}
}