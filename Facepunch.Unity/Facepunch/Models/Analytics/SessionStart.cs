using System;

namespace Facepunch.Models.Analytics
{
	internal class SessionStart
	{
		public string Uid;

		public string Sid;

		public string Bucket;

		public string ChangeSet;

		public string Branch;

		public string Os;

		public string Gpu;

		public string Cpu;

		public int CpuCnt;

		public int Mem;

		public int GpuMem;

		public int CpuFrq;

		public string Arch;

		public bool Fullscreen;

		public int Height;

		public int Width;

		public int RR;

		public int Version
		{
			get
			{
				return 2;
			}
		}

		public SessionStart()
		{
		}
	}
}