using System;
using System.Runtime.CompilerServices;

public static class BaseEntityEx
{
	public static bool IsValid(this BaseEntity ent)
	{
		if (ent == null)
		{
			return false;
		}
		if (ent.net == null)
		{
			return false;
		}
		return true;
	}

	public static bool IsValidEntityReference<T>(this T obj)
	where T : class
	{
		return (object)obj is BaseEntity;
	}
}