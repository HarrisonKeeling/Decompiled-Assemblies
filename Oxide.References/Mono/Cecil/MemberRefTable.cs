using Mono.Cecil.Metadata;
using System;

namespace Mono.Cecil
{
	internal sealed class MemberRefTable : MetadataTable<Row<uint, uint, uint>>
	{
		public MemberRefTable()
		{
		}

		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteCodedRID(this.rows[i].Col1, CodedIndex.MemberRefParent);
				buffer.WriteString(this.rows[i].Col2);
				buffer.WriteBlob(this.rows[i].Col3);
			}
		}
	}
}