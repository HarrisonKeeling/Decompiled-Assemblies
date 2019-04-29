using Mono.Cecil.PE;
using System;

namespace Mono.Cecil.Metadata
{
	internal sealed class DataBuffer : ByteBuffer
	{
		public DataBuffer() : base(0)
		{
		}

		public uint AddData(byte[] data)
		{
			int num = this.position;
			base.WriteBytes(data);
			return (uint)num;
		}
	}
}