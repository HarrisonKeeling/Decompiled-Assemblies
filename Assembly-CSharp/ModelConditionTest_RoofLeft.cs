using System;
using System.Collections.Generic;
using UnityEngine;

public class ModelConditionTest_RoofLeft : ModelConditionTest
{
	private const string socket = "roof/sockets/neighbour/2";

	private const string socket_female = "roof/sockets/neighbour/1";

	public ModelConditionTest_RoofLeft()
	{
	}

	public override bool DoTest(BaseEntity ent)
	{
		EntityLink entityLink = ent.FindLink("roof/sockets/neighbour/2");
		if (entityLink == null)
		{
			return false;
		}
		for (int i = 0; i < entityLink.connections.Count; i++)
		{
			if (entityLink.connections[i].name == "roof/sockets/neighbour/1")
			{
				return false;
			}
		}
		return true;
	}

	protected void OnDrawGizmosSelected()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.color = Color.gray;
		Gizmos.DrawWireCube(new Vector3(3f, 1.5f, 0f), new Vector3(3f, 3f, 3f));
	}
}