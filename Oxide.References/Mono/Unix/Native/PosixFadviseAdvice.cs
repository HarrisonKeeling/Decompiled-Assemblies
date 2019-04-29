using System;

namespace Mono.Unix.Native
{
	[CLSCompliant(false)]
	[Map]
	public enum PosixFadviseAdvice
	{
		POSIX_FADV_NORMAL,
		POSIX_FADV_RANDOM,
		POSIX_FADV_SEQUENTIAL,
		POSIX_FADV_WILLNEED,
		POSIX_FADV_DONTNEED,
		POSIX_FADV_NOREUSE
	}
}