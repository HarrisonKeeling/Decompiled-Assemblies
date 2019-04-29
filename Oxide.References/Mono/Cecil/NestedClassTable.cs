using Mono.Cecil.Metadata;
using System;

namespace Mono.Cecil
{
	internal sealed class NestedClassTable : SortedTable<Row<uint, uint>>
	{
		public NestedClassTable()
		{
		}

		public override int Compare(Row<uint, uint> x, Row<uint, uint> y)
		{
			return base.Compare((uint)x.Col1, (uint)y.Col1);
		}

		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteRID(this.rows[i].Col1, Table.TypeDef);
				buffer.WriteRID(this.rows[i].Col2, Table.TypeDef);
			}
		}
	}
}