using System;

namespace Facepunch
{
	internal static class Pool<T>
	where T : class
	{
		public static Pool.PoolCollection<T> Collection;
	}
}