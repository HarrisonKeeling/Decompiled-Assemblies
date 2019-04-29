using Mono.Cecil.Metadata;
using System;

namespace Mono.Cecil
{
	internal sealed class ModuleRefTable : MetadataTable<uint>
	{
		public ModuleRefTable()
		{
		}

		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteString(this.rows[i]);
			}
		}
	}
}