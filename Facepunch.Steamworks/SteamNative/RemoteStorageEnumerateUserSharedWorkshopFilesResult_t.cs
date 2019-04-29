using Facepunch.Steamworks;
using Facepunch.Steamworks.Interop;
using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	internal struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		internal const int CallbackId = 1326;

		internal SteamNative.Result Result;

		internal int ResultsReturned;

		internal int TotalResultCount;

		internal ulong[] GPublishedFileId;

		internal static RemoteStorageEnumerateUserSharedWorkshopFilesResult_t FromPointer(IntPtr p)
		{
			if (!Platform.PackSmall)
			{
				return (RemoteStorageEnumerateUserSharedWorkshopFilesResult_t)Marshal.PtrToStructure(p, typeof(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t));
			}
			return (RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.PackSmall)Marshal.PtrToStructure(p, typeof(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.PackSmall));
		}

		[MonoPInvokeCallback]
		internal static int OnGetSize()
		{
			return RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.StructSize();
		}

		[MonoPInvokeCallback]
		internal static int OnGetSizeThis(IntPtr self)
		{
			return RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnGetSize();
		}

		[MonoPInvokeCallback]
		internal static void OnResult(IntPtr param)
		{
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultWithInfo(param, false, (long)0);
		}

		[MonoPInvokeCallback]
		internal static void OnResultThis(IntPtr self, IntPtr param)
		{
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResult(param);
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call)
		{
			if (failure)
			{
				return;
			}
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t remoteStorageEnumerateUserSharedWorkshopFilesResultT = RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.FromPointer(param);
			if (Client.Instance != null)
			{
				Client.Instance.OnCallback<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>(remoteStorageEnumerateUserSharedWorkshopFilesResultT);
			}
			if (Server.Instance != null)
			{
				Server.Instance.OnCallback<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>(remoteStorageEnumerateUserSharedWorkshopFilesResultT);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call)
		{
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultWithInfo(param, failure, call);
		}

		internal static void Register(BaseSteamworks steamworks)
		{
			CallbackHandle callbackHandle = new CallbackHandle(steamworks);
			if (Config.UseThisCall)
			{
				if (!Platform.IsWindows)
				{
					callbackHandle.vTablePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Callback.VTableThis)));
					Callback.VTableThis vTableThi = new Callback.VTableThis()
					{
						ResultA = new Callback.VTableThis.ResultD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultThis),
						ResultB = new Callback.VTableThis.ResultWithInfoD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableThis.GetSizeD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnGetSizeThis)
					};
					callbackHandle.FuncA = GCHandle.Alloc(vTableThi.ResultA);
					callbackHandle.FuncB = GCHandle.Alloc(vTableThi.ResultB);
					callbackHandle.FuncC = GCHandle.Alloc(vTableThi.GetSize);
					Marshal.StructureToPtr(vTableThi, callbackHandle.vTablePtr, false);
				}
				else
				{
					callbackHandle.vTablePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Callback.VTableWinThis)));
					Callback.VTableWinThis vTableWinThi = new Callback.VTableWinThis()
					{
						ResultA = new Callback.VTableWinThis.ResultD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultThis),
						ResultB = new Callback.VTableWinThis.ResultWithInfoD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableWinThis.GetSizeD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnGetSizeThis)
					};
					callbackHandle.FuncA = GCHandle.Alloc(vTableWinThi.ResultA);
					callbackHandle.FuncB = GCHandle.Alloc(vTableWinThi.ResultB);
					callbackHandle.FuncC = GCHandle.Alloc(vTableWinThi.GetSize);
					Marshal.StructureToPtr(vTableWinThi, callbackHandle.vTablePtr, false);
				}
			}
			else if (!Platform.IsWindows)
			{
				callbackHandle.vTablePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Callback.VTable)));
				Callback.VTable vTable = new Callback.VTable()
				{
					ResultA = new Callback.VTable.ResultD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResult),
					ResultB = new Callback.VTable.ResultWithInfoD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultWithInfo),
					GetSize = new Callback.VTable.GetSizeD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnGetSize)
				};
				callbackHandle.FuncA = GCHandle.Alloc(vTable.ResultA);
				callbackHandle.FuncB = GCHandle.Alloc(vTable.ResultB);
				callbackHandle.FuncC = GCHandle.Alloc(vTable.GetSize);
				Marshal.StructureToPtr(vTable, callbackHandle.vTablePtr, false);
			}
			else
			{
				callbackHandle.vTablePtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Callback.VTableWin)));
				Callback.VTableWin vTableWin = new Callback.VTableWin()
				{
					ResultA = new Callback.VTableWin.ResultD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResult),
					ResultB = new Callback.VTableWin.ResultWithInfoD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnResultWithInfo),
					GetSize = new Callback.VTableWin.GetSizeD(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.OnGetSize)
				};
				callbackHandle.FuncA = GCHandle.Alloc(vTableWin.ResultA);
				callbackHandle.FuncB = GCHandle.Alloc(vTableWin.ResultB);
				callbackHandle.FuncC = GCHandle.Alloc(vTableWin.GetSize);
				Marshal.StructureToPtr(vTableWin, callbackHandle.vTablePtr, false);
			}
			Callback callback = new Callback()
			{
				vTablePtr = callbackHandle.vTablePtr,
				CallbackFlags = (byte)((steamworks.IsGameServer ? 2 : 0)),
				CallbackId = 1326
			};
			callbackHandle.PinnedCallback = GCHandle.Alloc(callback, GCHandleType.Pinned);
			steamworks.native.api.SteamAPI_RegisterCallback(callbackHandle.PinnedCallback.AddrOfPinnedObject(), 1326);
			steamworks.RegisterCallbackHandle(callbackHandle);
		}

		internal static int StructSize()
		{
			if (Platform.PackSmall)
			{
				return Marshal.SizeOf(typeof(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.PackSmall));
			}
			return Marshal.SizeOf(typeof(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t));
		}

		internal struct PackSmall
		{
			internal SteamNative.Result Result;

			internal int ResultsReturned;

			internal int TotalResultCount;

			internal ulong[] GPublishedFileId;

			public static implicit operator RemoteStorageEnumerateUserSharedWorkshopFilesResult_t(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.PackSmall d)
			{
				RemoteStorageEnumerateUserSharedWorkshopFilesResult_t remoteStorageEnumerateUserSharedWorkshopFilesResultT = new RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
				{
					Result = d.Result,
					ResultsReturned = d.ResultsReturned,
					TotalResultCount = d.TotalResultCount,
					GPublishedFileId = d.GPublishedFileId
				};
				return remoteStorageEnumerateUserSharedWorkshopFilesResultT;
			}
		}
	}
}