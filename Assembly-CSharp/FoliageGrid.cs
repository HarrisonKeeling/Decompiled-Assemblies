using System;
using UnityEngine.Rendering;

public class FoliageGrid : SingletonComponent<FoliageGrid>, IClientComponent
{
	public static bool Paused;

	public GameObjectRef BatchPrefab;

	public float CellSize = 50f;

	public float MaxMilliseconds = 0.1f;

	public LayerSelect FoliageLayer = 0;

	public ShadowCastingMode FoliageShadows;

	public const float MaxRefreshDistance = 100f;

	static FoliageGrid()
	{
	}

	public FoliageGrid()
	{
	}
}