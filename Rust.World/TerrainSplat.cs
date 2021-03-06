using System;
using System.Collections.Generic;

public static class TerrainSplat
{
	public const int COUNT = 8;

	public const int EVERYTHING = -1;

	public const int NOTHING = 0;

	public const int DIRT = 1;

	public const int SNOW = 2;

	public const int SAND = 4;

	public const int ROCK = 8;

	public const int GRASS = 16;

	public const int FOREST = 32;

	public const int STONES = 64;

	public const int GRAVEL = 128;

	public const int DIRT_IDX = 0;

	public const int SNOW_IDX = 1;

	public const int SAND_IDX = 2;

	public const int ROCK_IDX = 3;

	public const int GRASS_IDX = 4;

	public const int FOREST_IDX = 5;

	public const int STONES_IDX = 6;

	public const int GRAVEL_IDX = 7;

	private static Dictionary<int, int> type2index;

	static TerrainSplat()
	{
		TerrainSplat.type2index = new Dictionary<int, int>()
		{
			{ 8, 3 },
			{ 16, 4 },
			{ 4, 2 },
			{ 1, 0 },
			{ 32, 5 },
			{ 64, 6 },
			{ 2, 1 },
			{ 128, 7 }
		};
	}

	public static int IndexToType(int idx)
	{
		return 1 << (idx & 31);
	}

	public static int TypeToIndex(int id)
	{
		return TerrainSplat.type2index[id];
	}

	public enum Enum
	{
		Dirt = 1,
		Snow = 2,
		Sand = 4,
		Rock = 8,
		Grass = 16,
		Forest = 32,
		Stones = 64,
		Gravel = 128
	}
}