using Mono.Cecil.Metadata;
using System;

namespace Mono.Cecil
{
	internal sealed class GenericParamConstraintTable : MetadataTable<Row<uint, uint>>
	{
		public GenericParamConstraintTable()
		{
		}

		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteRID(this.rows[i].Col1, Table.GenericParam);
				buffer.WriteCodedRID(this.rows[i].Col2, CodedIndex.TypeDefOrRef);
			}
		}
	}
}