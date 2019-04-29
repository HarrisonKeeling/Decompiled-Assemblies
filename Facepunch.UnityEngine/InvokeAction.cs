using System;
using UnityEngine;

public struct InvokeAction : IEquatable<InvokeAction>
{
	public Behaviour sender;

	public Action action;

	public float initial;

	public float repeat;

	public float random;

	public InvokeAction(Behaviour sender, Action action, float initial = 0f, float repeat = -1f, float random = 0f)
	{
		this.sender = sender;
		this.action = action;
		this.initial = initial;
		this.repeat = repeat;
		this.random = random;
	}

	public bool Equals(InvokeAction other)
	{
		if (this.sender != other.sender)
		{
			return false;
		}
		return this.action == other.action;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is InvokeAction))
		{
			return false;
		}
		return this.Equals((InvokeAction)obj);
	}

	public override int GetHashCode()
	{
		return this.sender.GetHashCode();
	}

	public static bool operator ==(InvokeAction x, InvokeAction y)
	{
		return x.Equals(y);
	}

	public static bool operator !=(InvokeAction x, InvokeAction y)
	{
		return !x.Equals(y);
	}
}