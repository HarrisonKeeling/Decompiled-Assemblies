using System;
using UnityEngine;

public static class Mathx
{
	public static float Above(float latitude, float lower, float fade = 0.1f)
	{
		latitude = latitude - fade * 0.5f;
		return Mathf.Clamp01((latitude - lower + fade) / fade);
	}

	public static float Below(float latitude, float upper, float fade = 0.1f)
	{
		latitude = latitude - fade * 0.5f;
		return Mathf.Clamp01((upper - latitude) / fade);
	}

	public static int Clamp(int v, int min, int max)
	{
		if (v < min)
		{
			return min;
		}
		if (v <= max)
		{
			return v;
		}
		return max;
	}

	public static float Decrement(float f)
	{
		unsafe
		{
			if (float.IsNaN(f))
			{
				return f;
			}
			if (f == 0f)
			{
				return -1.401298E-45f;
			}
			int num = (int)f;
			num = (f > 0f ? num - 1 : num + 1);
			return (float)num;
		}
	}

	public static float Discretize01(float v, int steps)
	{
		return (float)Mathf.RoundToInt(Mathf.Clamp01(v) * (float)steps) / (float)steps;
	}

	public static float fsel(float c, float x, float y)
	{
		if (c >= 0f)
		{
			return x;
		}
		return y;
	}

	public static float Increment(float f)
	{
		unsafe
		{
			if (float.IsNaN(f))
			{
				return f;
			}
			if (f == 0f)
			{
				return 1.401298E-45f;
			}
			int num = (int)f;
			num = (f > 0f ? num + 1 : num - 1);
			return (float)num;
		}
	}

	public static Color Lerp3(float f1, Color c1, float f2, Color c2, float f3, Color c3)
	{
		if (f1 == 1f)
		{
			return c1;
		}
		if (f2 == 1f)
		{
			return c2;
		}
		if (f3 == 1f)
		{
			return c3;
		}
		if (f3 == 0f)
		{
			return (f1 * c1) + (f2 * c2);
		}
		if (f1 == 0f)
		{
			return (f2 * c2) + (f3 * c3);
		}
		return ((f1 * c1) + (f2 * c2)) + (f3 * c3);
	}

	public static float Max(float f1, float f2, float f3)
	{
		return Mathf.Max(Mathf.Max(f1, f2), f3);
	}

	public static float Max(float f1, float f2, float f3, float f4)
	{
		return Mathf.Max(Mathf.Max(f1, f2), Mathf.Max(f3, f4));
	}

	public static int Max(int f1, int f2, int f3)
	{
		return Mathf.Max(Mathf.Max(f1, f2), f3);
	}

	public static int Max(int f1, int f2, int f3, int f4)
	{
		return Mathf.Max(Mathf.Max(f1, f2), Mathf.Max(f3, f4));
	}

	public static uint Max(uint i1, uint i2)
	{
		if (i1 <= i2)
		{
			return i2;
		}
		return i1;
	}

	public static float Min(float f1, float f2, float f3)
	{
		return Mathf.Min(Mathf.Min(f1, f2), f3);
	}

	public static float Min(float f1, float f2, float f3, float f4)
	{
		return Mathf.Min(Mathf.Min(f1, f2), Mathf.Min(f3, f4));
	}

	public static int Min(int f1, int f2, int f3)
	{
		return Mathf.Min(Mathf.Min(f1, f2), f3);
	}

	public static int Min(int f1, int f2, int f3, int f4)
	{
		return Mathf.Min(Mathf.Min(f1, f2), Mathf.Min(f3, f4));
	}

	public static uint Min(uint i1, uint i2)
	{
		if (i1 >= i2)
		{
			return i2;
		}
		return i1;
	}

	public static float RemapValClamped(float val, float A, float B, float C, float D)
	{
		if (A == B)
		{
			return Mathx.fsel(val - B, D, C);
		}
		float single = (val - A) / (B - A);
		single = Mathf.Clamp(single, 0f, 1f);
		return C + (D - C) * single;
	}

	public static int Sign(int v)
	{
		return Math.Sign(v);
	}

	public static float SmoothMax(float a, float b, float fade = 0.1f)
	{
		return Mathf.SmoothStep(a, b, 0.5f + (b - a) / fade);
	}

	public static float Tween(float latitude, float lower, float upper, float fade = 0.1f)
	{
		latitude = latitude - fade * 0.5f;
		return Mathf.Clamp01((latitude - lower + fade) / fade) * Mathf.Clamp01((upper - latitude) / fade);
	}
}