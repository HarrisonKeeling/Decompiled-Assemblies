using System;
using UnityEngine;

public class TerrainCheckGeneratorVolumes : MonoBehaviour, IEditorComponent
{
	public float PlacementRadius;

	public TerrainCheckGeneratorVolumes()
	{
	}

	protected void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 1f);
		GizmosUtil.DrawWireCircleY(base.transform.position, this.PlacementRadius);
	}
}