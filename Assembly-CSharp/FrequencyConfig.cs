using System;
using UnityEngine.UI;

public class FrequencyConfig : UIDialog
{
	[NonSerialized]
	private IRFObject rfObject;

	public InputField input;

	public int target;

	public FrequencyConfig()
	{
	}
}