using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oxide.Game.Rust.Cui
{
	public class CuiRectTransformComponent : ICuiComponent
	{
		[DefaultValue("1.0 1.0")]
		[JsonProperty("anchormax")]
		public string AnchorMax { get; set; } = "1.0 1.0";

		[DefaultValue("0.0 0.0")]
		[JsonProperty("anchormin")]
		public string AnchorMin { get; set; } = "0.0 0.0";

		[DefaultValue("0.0 0.0")]
		[JsonProperty("offsetmax")]
		public string OffsetMax { get; set; } = "0.0 0.0";

		[DefaultValue("0.0 0.0")]
		[JsonProperty("offsetmin")]
		public string OffsetMin { get; set; } = "0.0 0.0";

		public string Type
		{
			get
			{
				return "RectTransform";
			}
		}

		public CuiRectTransformComponent()
		{
		}
	}
}