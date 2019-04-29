using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragMe : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public static DragMe dragging;

	public static GameObject dragIcon;

	public static object data;

	[NonSerialized]
	public string dragType = "generic";

	public DragMe()
	{
	}

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}
}