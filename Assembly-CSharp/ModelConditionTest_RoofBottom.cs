using System;
using System.Collections.Generic;
using UnityEngine;

public class ModelConditionTest_RoofBottom : ModelConditionTest
{
	private const string socket = "roof/sockets/wall-male";

	private const string socket_female = "roof/sockets/wall-female";

	public ModelConditionTest_RoofBottom()
	{
	}

	public override bool DoTest(BaseEntity ent)
	{
		EntityLink entityLink = ent.FindLink("roof/sockets/wall-male");
		if (entityLink == null)
		{
			return false;
		}
		for (int i = 0; i < entityLink.connections.Count; i++)
		{
			if (entityLink.connections[i].name == "roof/sockets/wall-female")
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
		Gizmos.DrawWireCube(new Vector3(0f, -1.5f, 3f), new Vector3(3f, 3f, 3f));
	}
}