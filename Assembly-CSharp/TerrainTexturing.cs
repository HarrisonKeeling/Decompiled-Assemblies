using System;
using UnityEngine;

[ExecuteInEditMode]
public class TerrainTexturing : TerrainExtension
{
	private const int coarseHeightDownscale = 1;

	public bool debugFoliageDisplacement;

	private const int CoarseSlopeBlurPasses = 4;

	private const float CoarseSlopeBlurRadius = 1f;

	public TerrainTexturing()
	{
	}
}