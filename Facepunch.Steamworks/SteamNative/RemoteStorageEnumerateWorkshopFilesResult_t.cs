using Facepunch.Steamworks;
using Facepunch.Steamworks.Interop;
using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	internal struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		internal const int CallbackId = 1319;

		internal SteamNative.Result Result;

		internal int ResultsReturned;

		internal int TotalResultCount;

		internal ulong[] GPublishedFileId;

		internal float[] GScore;

		internal uint AppId;

		internal uint StartIndex;

		internal static CallResult<RemoteStorageEnumerateWorkshopFilesResult_t> CallResult(BaseSteamworks steamworks, SteamAPICall_t call, Action<RemoteStorageEnumerateWorkshopFilesResult_t, bool> CallbackFunction)
		{
			return new CallResult<RemoteStorageEnumerateWorkshopFilesResult_t>(steamworks, call, CallbackFunction, new CallResult<RemoteStorageEnumerateWorkshopFilesResult_t>.ConvertFromPointer(RemoteStorageEnumerateWorkshopFilesResult_t.FromPointer), RemoteStorageEnumerateWorkshopFilesResult_t.StructSize(), 1319);
		}

		internal static RemoteStorageEnumerateWorkshopFilesResult_t FromPointer(IntPtr p)
		{
			if (!Platform.PackSmall)
			{
				return (RemoteStorageEnumerateWorkshopFilesResult_t)Marshal.PtrToStructure(p, typeof(RemoteStorageEnumerateWorkshopFilesResult_t));
			}
			return (RemoteStorageEnumerateWorkshopFilesResult_t.PackSmall)Marshal.PtrToStructure(p, typeof(RemoteStorageEnumerateWorkshopFilesResult_t.PackSmall));
		}

		[MonoPInvokeCallback]
		internal static int OnGetSize()
		{
			return RemoteStorageEnumerateWorkshopFilesResult_t.StructSize();
		}

		[MonoPInvokeCallback]
		internal static int OnGetSizeThis(IntPtr self)
		{
			return RemoteStorageEnumerateWorkshopFilesResult_t.OnGetSize();
		}

		[MonoPInvokeCallback]
		internal static void OnResult(IntPtr param)
		{
			RemoteStorageEnumerateWorkshopFilesResult_t.OnResultWithInfo(param, false, (long)0);
		}

		[MonoPInvokeCallback]
		internal static void OnResultThis(IntPtr self, IntPtr param)
		{
			RemoteStorageEnumerateWorkshopFilesResult_t.OnResult(param);
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call)
		{
			if (failure)
			{
				return;
			}
			RemoteStorageEnumerateWorkshopFilesResult_t remoteStorageEnumerateWorkshopFilesResultT = RemoteStorageEnumerateWorkshopFilesResult_t.FromPointer(param);
			if (Client.Instance != null)
			{
				Client.Instance.OnCallback<RemoteStorageEnumerateWorkshopFilesResult_t>(remoteStorageEnumerateWorkshopFilesResultT);
			}
			if (Server.Instance != null)
			{
				Server.Instance.OnCallback<RemoteStorageEnumerateWorkshopFilesResult_t>(remoteStorageEnumerateWorkshopFilesResultT);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call)
		{
			RemoteStorageEnumerateWorkshopFilesResult_t.OnResultWithInfo(param, failure, call);
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
						ResultA = new Callback.VTableThis.ResultD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResultThis),
						ResultB = new Callback.VTableThis.ResultWithInfoD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableThis.GetSizeD(RemoteStorageEnumerateWorkshopFilesResult_t.OnGetSizeThis)
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
						ResultA = new Callback.VTableWinThis.ResultD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResultThis),
						ResultB = new Callback.VTableWinThis.ResultWithInfoD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableWinThis.GetSizeD(RemoteStorageEnumerateWorkshopFilesResult_t.OnGetSizeThis)
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
					ResultA = new Callback.VTable.ResultD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResult),
					ResultB = new Callback.VTable.ResultWithInfoD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResultWithInfo),
					GetSize = new Callback.VTable.GetSizeD(RemoteStorageEnumerateWorkshopFilesResult_t.OnGetSize)
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
					ResultA = new Callback.VTableWin.ResultD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResult),
					ResultB = new Callback.VTableWin.ResultWithInfoD(RemoteStorageEnumerateWorkshopFilesResult_t.OnResultWithInfo),
					GetSize = new Callback.VTableWin.GetSizeD(RemoteStorageEnumerateWorkshopFilesResult_t.OnGetSize)
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
				CallbackId = 1319
			};
			callbackHandle.PinnedCallback = GCHandle.Alloc(callback, GCHandleType.Pinned);
			steamworks.native.api.SteamAPI_RegisterCallback(callbackHandle.PinnedCallback.AddrOfPinnedObject(), 1319);
			steamworks.RegisterCallbackHandle(callbackHandle);
		}

		internal static int StructSize()
		{
			if (Platform.PackSmall)
			{
				return Marshal.SizeOf(typeof(RemoteStorageEnumerateWorkshopFilesResult_t.PackSmall));
			}
			return Marshal.SizeOf(typeof(RemoteStorageEnumerateWorkshopFilesResult_t));
		}

		internal struct PackSmall
		{
			internal SteamNative.Result Result;

			internal int ResultsReturned;

			internal int TotalResultCount;

			internal ulong[] GPublishedFileId;

			internal float[] GScore;

			internal uint AppId;

			internal uint StartIndex;

			public static implicit operator RemoteStorageEnumerateWorkshopFilesResult_t(RemoteStorageEnumerateWorkshopFilesResult_t.PackSmall d)
			{
				RemoteStorageEnumerateWorkshopFilesResult_t remoteStorageEnumerateWorkshopFilesResultT = new RemoteStorageEnumerateWorkshopFilesResult_t()
				{
					Result = d.Result,
					ResultsReturned = d.ResultsReturned,
					TotalResultCount = d.TotalResultCount,
					GPublishedFileId = d.GPublishedFileId,
					GScore = d.GScore,
					AppId = d.AppId,
					StartIndex = d.StartIndex
				};
				return remoteStorageEnumerateWorkshopFilesResultT;
			}
		}
	}
}