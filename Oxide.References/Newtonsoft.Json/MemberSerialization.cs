using Newtonsoft.Json.Shims;
using System;

namespace Newtonsoft.Json
{
	[Preserve]
	public enum MemberSerialization
	{
		OptOut,
		OptIn,
		Fields
	}
}