using System;

[Serializable]
public struct ExtendGBufferParams
{
	public bool enabled;

	public static ExtendGBufferParams Default;

	static ExtendGBufferParams()
	{
		ExtendGBufferParams.Default = new ExtendGBufferParams()
		{
			enabled = false
		};
	}
}