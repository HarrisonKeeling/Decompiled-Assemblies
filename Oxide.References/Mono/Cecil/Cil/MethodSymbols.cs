using Mono.Cecil;
using Mono.Collections.Generic;
using System;

namespace Mono.Cecil.Cil
{
	public sealed class MethodSymbols
	{
		internal int code_size;

		internal string method_name;

		internal MetadataToken method_token;

		internal MetadataToken local_var_token;

		internal Collection<VariableDefinition> variables;

		internal Collection<InstructionSymbol> instructions;

		public int CodeSize
		{
			get
			{
				return this.code_size;
			}
		}

		public bool HasVariables
		{
			get
			{
				return !this.variables.IsNullOrEmpty<VariableDefinition>();
			}
		}

		public Collection<InstructionSymbol> Instructions
		{
			get
			{
				if (this.instructions == null)
				{
					this.instructions = new Collection<InstructionSymbol>();
				}
				return this.instructions;
			}
		}

		public MetadataToken LocalVarToken
		{
			get
			{
				return this.local_var_token;
			}
		}

		public string MethodName
		{
			get
			{
				return this.method_name;
			}
		}

		public MetadataToken MethodToken
		{
			get
			{
				return this.method_token;
			}
		}

		public Collection<VariableDefinition> Variables
		{
			get
			{
				if (this.variables == null)
				{
					this.variables = new Collection<VariableDefinition>();
				}
				return this.variables;
			}
		}

		internal MethodSymbols(string methodName)
		{
			this.method_name = methodName;
		}

		public MethodSymbols(MetadataToken methodToken)
		{
			this.method_token = methodToken;
		}
	}
}