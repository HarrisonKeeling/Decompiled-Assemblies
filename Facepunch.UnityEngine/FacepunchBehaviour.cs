using System;
using UnityEngine;

public abstract class FacepunchBehaviour : MonoBehaviour
{
	protected FacepunchBehaviour()
	{
	}

	public void CancelInvoke(Action action)
	{
		InvokeHandler.CancelInvoke(this, action);
	}

	public void Invoke(Action action, float time)
	{
		InvokeHandler.Invoke(this, action, time);
	}

	public void InvokeRandomized(Action action, float time, float repeat, float random)
	{
		InvokeHandler.InvokeRandomized(this, action, time, repeat, random);
	}

	public void InvokeRepeating(Action action, float time, float repeat)
	{
		InvokeHandler.InvokeRepeating(this, action, time, repeat);
	}

	public bool IsInvoking(Action action)
	{
		return InvokeHandler.IsInvoking(this, action);
	}
}