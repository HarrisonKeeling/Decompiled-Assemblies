using Mono.Cecil.Metadata;
using System;

namespace Mono.Cecil
{
	internal sealed class EventMapTable : MetadataTable<Row<uint, uint>>
	{
		public EventMapTable()
		{
		}

		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteRID(this.rows[i].Col1, Table.TypeDef);
				buffer.WriteRID(this.rows[i].Col2, Table.Event);
			}
		}
	}
}