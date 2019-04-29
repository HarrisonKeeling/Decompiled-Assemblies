using Mono.Cecil.Metadata;
using Mono.Cecil.PE;
using System;

namespace Mono.Cecil
{
	internal sealed class AssemblyRefTable : MetadataTable<Row<ushort, ushort, ushort, ushort, AssemblyAttributes, uint, uint, uint, uint>>
	{
		public AssemblyRefTable()
		{
		}

		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteUInt16(this.rows[i].Col1);
				buffer.WriteUInt16(this.rows[i].Col2);
				buffer.WriteUInt16(this.rows[i].Col3);
				buffer.WriteUInt16(this.rows[i].Col4);
				buffer.WriteUInt32(this.rows[i].Col5);
				buffer.WriteBlob(this.rows[i].Col6);
				buffer.WriteString(this.rows[i].Col7);
				buffer.WriteString(this.rows[i].Col8);
				buffer.WriteBlob(this.rows[i].Col9);
			}
		}
	}
}