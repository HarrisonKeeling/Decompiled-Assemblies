using System;

namespace Mono.Unix.Native
{
	[CLSCompliant(false)]
	[Map]
	public enum LockfCommand
	{
		F_ULOCK,
		F_LOCK,
		F_TLOCK,
		F_TEST
	}
}