using System;
using System.Collections.Generic;
using UnityEngine;

public class ModelConditionTest_RoofTop : ModelConditionTest
{
	private const string socket = "roof/sockets/wall-female";

	private const string socket_male = "roof/sockets/wall-male";

	public ModelConditionTest_RoofTop()
	{
	}

	public override bool DoTest(BaseEntity ent)
	{
		EntityLink entityLink = ent.FindLink("roof/sockets/wall-female");
		if (entityLink == null)
		{
			return false;
		}
		for (int i = 0; i < entityLink.connections.Count; i++)
		{
			if (entityLink.connections[i].name == "roof/sockets/wall-male")
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
		Gizmos.DrawWireCube(new Vector3(0f, 4.5f, -3f), new Vector3(3f, 3f, 3f));
	}
}