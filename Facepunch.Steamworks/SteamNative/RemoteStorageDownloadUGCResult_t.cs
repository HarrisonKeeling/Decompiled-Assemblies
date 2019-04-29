using Facepunch.Steamworks;
using Facepunch.Steamworks.Interop;
using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	internal struct RemoteStorageDownloadUGCResult_t
	{
		internal const int CallbackId = 1317;

		internal SteamNative.Result Result;

		internal ulong File;

		internal uint AppID;

		internal int SizeInBytes;

		internal string PchFileName;

		internal ulong SteamIDOwner;

		internal static CallResult<RemoteStorageDownloadUGCResult_t> CallResult(BaseSteamworks steamworks, SteamAPICall_t call, Action<RemoteStorageDownloadUGCResult_t, bool> CallbackFunction)
		{
			return new CallResult<RemoteStorageDownloadUGCResult_t>(steamworks, call, CallbackFunction, new CallResult<RemoteStorageDownloadUGCResult_t>.ConvertFromPointer(RemoteStorageDownloadUGCResult_t.FromPointer), RemoteStorageDownloadUGCResult_t.StructSize(), 1317);
		}

		internal static RemoteStorageDownloadUGCResult_t FromPointer(IntPtr p)
		{
			if (!Platform.PackSmall)
			{
				return (RemoteStorageDownloadUGCResult_t)Marshal.PtrToStructure(p, typeof(RemoteStorageDownloadUGCResult_t));
			}
			return (RemoteStorageDownloadUGCResult_t.PackSmall)Marshal.PtrToStructure(p, typeof(RemoteStorageDownloadUGCResult_t.PackSmall));
		}

		[MonoPInvokeCallback]
		internal static int OnGetSize()
		{
			return RemoteStorageDownloadUGCResult_t.StructSize();
		}

		[MonoPInvokeCallback]
		internal static int OnGetSizeThis(IntPtr self)
		{
			return RemoteStorageDownloadUGCResult_t.OnGetSize();
		}

		[MonoPInvokeCallback]
		internal static void OnResult(IntPtr param)
		{
			RemoteStorageDownloadUGCResult_t.OnResultWithInfo(param, false, (long)0);
		}

		[MonoPInvokeCallback]
		internal static void OnResultThis(IntPtr self, IntPtr param)
		{
			RemoteStorageDownloadUGCResult_t.OnResult(param);
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call)
		{
			if (failure)
			{
				return;
			}
			RemoteStorageDownloadUGCResult_t remoteStorageDownloadUGCResultT = RemoteStorageDownloadUGCResult_t.FromPointer(param);
			if (Client.Instance != null)
			{
				Client.Instance.OnCallback<RemoteStorageDownloadUGCResult_t>(remoteStorageDownloadUGCResultT);
			}
			if (Server.Instance != null)
			{
				Server.Instance.OnCallback<RemoteStorageDownloadUGCResult_t>(remoteStorageDownloadUGCResultT);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call)
		{
			RemoteStorageDownloadUGCResult_t.OnResultWithInfo(param, failure, call);
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
						ResultA = new Callback.VTableThis.ResultD(RemoteStorageDownloadUGCResult_t.OnResultThis),
						ResultB = new Callback.VTableThis.ResultWithInfoD(RemoteStorageDownloadUGCResult_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableThis.GetSizeD(RemoteStorageDownloadUGCResult_t.OnGetSizeThis)
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
						ResultA = new Callback.VTableWinThis.ResultD(RemoteStorageDownloadUGCResult_t.OnResultThis),
						ResultB = new Callback.VTableWinThis.ResultWithInfoD(RemoteStorageDownloadUGCResult_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableWinThis.GetSizeD(RemoteStorageDownloadUGCResult_t.OnGetSizeThis)
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
					ResultA = new Callback.VTable.ResultD(RemoteStorageDownloadUGCResult_t.OnResult),
					ResultB = new Callback.VTable.ResultWithInfoD(RemoteStorageDownloadUGCResult_t.OnResultWithInfo),
					GetSize = new Callback.VTable.GetSizeD(RemoteStorageDownloadUGCResult_t.OnGetSize)
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
					ResultA = new Callback.VTableWin.ResultD(RemoteStorageDownloadUGCResult_t.OnResult),
					ResultB = new Callback.VTableWin.ResultWithInfoD(RemoteStorageDownloadUGCResult_t.OnResultWithInfo),
					GetSize = new Callback.VTableWin.GetSizeD(RemoteStorageDownloadUGCResult_t.OnGetSize)
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
				CallbackId = 1317
			};
			callbackHandle.PinnedCallback = GCHandle.Alloc(callback, GCHandleType.Pinned);
			steamworks.native.api.SteamAPI_RegisterCallback(callbackHandle.PinnedCallback.AddrOfPinnedObject(), 1317);
			steamworks.RegisterCallbackHandle(callbackHandle);
		}

		internal static int StructSize()
		{
			if (Platform.PackSmall)
			{
				return Marshal.SizeOf(typeof(RemoteStorageDownloadUGCResult_t.PackSmall));
			}
			return Marshal.SizeOf(typeof(RemoteStorageDownloadUGCResult_t));
		}

		internal struct PackSmall
		{
			internal SteamNative.Result Result;

			internal ulong File;

			internal uint AppID;

			internal int SizeInBytes;

			internal string PchFileName;

			internal ulong SteamIDOwner;

			public static implicit operator RemoteStorageDownloadUGCResult_t(RemoteStorageDownloadUGCResult_t.PackSmall d)
			{
				RemoteStorageDownloadUGCResult_t remoteStorageDownloadUGCResultT = new RemoteStorageDownloadUGCResult_t()
				{
					Result = d.Result,
					File = d.File,
					AppID = d.AppID,
					SizeInBytes = d.SizeInBytes,
					PchFileName = d.PchFileName,
					SteamIDOwner = d.SteamIDOwner
				};
				return remoteStorageDownloadUGCResultT;
			}
		}
	}
}