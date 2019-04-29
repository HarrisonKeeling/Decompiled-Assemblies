using System;
using UnityEngine;
using UnityEngine.UI;

public class MapGrid : MonoBehaviour
{
	public Text coordinatePrefab;

	public int gridCellSize = 200;

	public float lineThickness = 0.3f;

	public CanvasGroup @group;

	public float visibleAlphaLevel = 0.6f;

	public RawImage TargetImage;

	public bool show;

	public MapGrid()
	{
	}
}