using System;
using UnityEngine;

public class CrushTrigger : TriggerHurt
{
	public bool includeNPCs = true;

	public CrushTrigger()
	{
	}

	internal override GameObject InterestedInObject(GameObject obj)
	{
		obj = base.InterestedInObject(obj);
		if (obj == null)
		{
			return null;
		}
		BaseEntity baseEntity = obj.ToBaseEntity();
		if (baseEntity == null)
		{
			return null;
		}
		if (baseEntity.isClient)
		{
			return null;
		}
		if (!this.includeNPCs && baseEntity.IsNpc)
		{
			return null;
		}
		return baseEntity.gameObject;
	}
}