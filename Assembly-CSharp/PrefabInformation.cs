using System;
using UnityEngine;

public class PrefabInformation : PrefabAttribute
{
	public ItemDefinition associatedItemDefinition;

	public Translate.Phrase title;

	public Translate.Phrase description;

	public Sprite sprite;

	public PrefabInformation()
	{
	}

	protected override Type GetIndexedType()
	{
		return typeof(PrefabInformation);
	}
}