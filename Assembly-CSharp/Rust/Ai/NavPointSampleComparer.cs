using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rust.Ai
{
	public class NavPointSampleComparer : IComparer<NavPointSample>
	{
		public NavPointSampleComparer()
		{
		}

		public int Compare(NavPointSample a, NavPointSample b)
		{
			if (Mathf.Approximately(a.Score, b.Score))
			{
				return 0;
			}
			if (a.Score > b.Score)
			{
				return -1;
			}
			return 1;
		}
	}
}