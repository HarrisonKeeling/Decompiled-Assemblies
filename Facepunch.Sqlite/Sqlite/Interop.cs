using System;
using System.Runtime.InteropServices;

namespace Facepunch.Sqlite
{
	internal static class Interop
	{
		internal const int SQLITE_OK = 0;

		internal const int SQLITE_ROW = 100;

		internal const int SQLITE_DONE = 101;

		internal const int SQLITE_INTEGER = 1;

		internal const int SQLITE_FLOAT = 2;

		internal const int SQLITE_TEXT = 3;

		internal const int SQLITE_BLOB = 4;

		internal const int SQLITE_NULL = 5;

		internal static IntPtr SQLITE_STATIC;

		internal static IntPtr SQLITE_TRANSIENT;

		static Interop()
		{
			Interop.SQLITE_STATIC = new IntPtr(0);
			Interop.SQLITE_TRANSIENT = new IntPtr(-1);
		}

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern double sqlite3_bind_blob(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern double sqlite3_bind_double(IntPtr stmHandle, int i, double val);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern double sqlite3_bind_int64(IntPtr stmHandle, int i, long val);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern double sqlite3_bind_null(IntPtr stmHandle, int i);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern double sqlite3_bind_text16(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_close(IntPtr db);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr sqlite3_column_blob(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_column_bytes(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_column_count(IntPtr stmHandle);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern double sqlite3_column_double(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern long sqlite3_column_int64(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr sqlite3_column_name(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr sqlite3_column_text16(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_column_type(IntPtr stmHandle, int iCol);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr sqlite3_errmsg(IntPtr db);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_finalize(IntPtr stmHandle);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_open(string filename, out IntPtr db);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail);

		[DllImport("sqlite3", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern int sqlite3_step(IntPtr stmHandle);
	}
}