using System;

namespace Mono.Cecil
{
	public struct CustomAttributeNamedArgument
	{
		private readonly string name;

		private readonly CustomAttributeArgument argument;

		public CustomAttributeArgument Argument
		{
			get
			{
				return this.argument;
			}
		}

		public string Name
		{
			get
			{
				return this.name;
			}
		}

		public CustomAttributeNamedArgument(string name, CustomAttributeArgument argument)
		{
			Mixin.CheckName(name);
			this.name = name;
			this.argument = argument;
		}
	}
}