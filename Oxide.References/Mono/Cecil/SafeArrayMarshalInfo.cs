using System;

namespace Mono.Cecil
{
	public sealed class SafeArrayMarshalInfo : MarshalInfo
	{
		internal VariantType element_type;

		public VariantType ElementType
		{
			get
			{
				return this.element_type;
			}
			set
			{
				this.element_type = value;
			}
		}

		public SafeArrayMarshalInfo() : base(Mono.Cecil.NativeType.SafeArray)
		{
			this.element_type = VariantType.None;
		}
	}
}