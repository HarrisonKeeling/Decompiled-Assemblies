using System;
using UnityEngine;

public class Deployable : PrefabAttribute
{
	public Mesh guideMesh;

	public Vector3 guideMeshScale = Vector3.one;

	public bool guideLights = true;

	public bool wantsInstanceData;

	public bool copyInventoryFromItem;

	public bool setSocketParent;

	public bool toSlot;

	public BaseEntity.Slot slot;

	public GameObjectRef placeEffect;

	public Deployable()
	{
	}

	protected override Type GetIndexedType()
	{
		return typeof(Deployable);
	}
}