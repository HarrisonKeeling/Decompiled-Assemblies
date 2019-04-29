using Facepunch.Steamworks;
using Facepunch.Steamworks.Interop;
using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	internal struct RemoteStorageUserVoteDetails_t
	{
		internal const int CallbackId = 1325;

		internal SteamNative.Result Result;

		internal ulong PublishedFileId;

		internal WorkshopVote Vote;

		internal static RemoteStorageUserVoteDetails_t FromPointer(IntPtr p)
		{
			if (!Platform.PackSmall)
			{
				return (RemoteStorageUserVoteDetails_t)Marshal.PtrToStructure(p, typeof(RemoteStorageUserVoteDetails_t));
			}
			return (RemoteStorageUserVoteDetails_t.PackSmall)Marshal.PtrToStructure(p, typeof(RemoteStorageUserVoteDetails_t.PackSmall));
		}

		[MonoPInvokeCallback]
		internal static int OnGetSize()
		{
			return RemoteStorageUserVoteDetails_t.StructSize();
		}

		[MonoPInvokeCallback]
		internal static int OnGetSizeThis(IntPtr self)
		{
			return RemoteStorageUserVoteDetails_t.OnGetSize();
		}

		[MonoPInvokeCallback]
		internal static void OnResult(IntPtr param)
		{
			RemoteStorageUserVoteDetails_t.OnResultWithInfo(param, false, (long)0);
		}

		[MonoPInvokeCallback]
		internal static void OnResultThis(IntPtr self, IntPtr param)
		{
			RemoteStorageUserVoteDetails_t.OnResult(param);
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call)
		{
			if (failure)
			{
				return;
			}
			RemoteStorageUserVoteDetails_t remoteStorageUserVoteDetailsT = RemoteStorageUserVoteDetails_t.FromPointer(param);
			if (Client.Instance != null)
			{
				Client.Instance.OnCallback<RemoteStorageUserVoteDetails_t>(remoteStorageUserVoteDetailsT);
			}
			if (Server.Instance != null)
			{
				Server.Instance.OnCallback<RemoteStorageUserVoteDetails_t>(remoteStorageUserVoteDetailsT);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call)
		{
			RemoteStorageUserVoteDetails_t.OnResultWithInfo(param, failure, call);
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
						ResultA = new Callback.VTableThis.ResultD(RemoteStorageUserVoteDetails_t.OnResultThis),
						ResultB = new Callback.VTableThis.ResultWithInfoD(RemoteStorageUserVoteDetails_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableThis.GetSizeD(RemoteStorageUserVoteDetails_t.OnGetSizeThis)
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
						ResultA = new Callback.VTableWinThis.ResultD(RemoteStorageUserVoteDetails_t.OnResultThis),
						ResultB = new Callback.VTableWinThis.ResultWithInfoD(RemoteStorageUserVoteDetails_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableWinThis.GetSizeD(RemoteStorageUserVoteDetails_t.OnGetSizeThis)
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
					ResultA = new Callback.VTable.ResultD(RemoteStorageUserVoteDetails_t.OnResult),
					ResultB = new Callback.VTable.ResultWithInfoD(RemoteStorageUserVoteDetails_t.OnResultWithInfo),
					GetSize = new Callback.VTable.GetSizeD(RemoteStorageUserVoteDetails_t.OnGetSize)
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
					ResultA = new Callback.VTableWin.ResultD(RemoteStorageUserVoteDetails_t.OnResult),
					ResultB = new Callback.VTableWin.ResultWithInfoD(RemoteStorageUserVoteDetails_t.OnResultWithInfo),
					GetSize = new Callback.VTableWin.GetSizeD(RemoteStorageUserVoteDetails_t.OnGetSize)
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
				CallbackId = 1325
			};
			callbackHandle.PinnedCallback = GCHandle.Alloc(callback, GCHandleType.Pinned);
			steamworks.native.api.SteamAPI_RegisterCallback(callbackHandle.PinnedCallback.AddrOfPinnedObject(), 1325);
			steamworks.RegisterCallbackHandle(callbackHandle);
		}

		internal static int StructSize()
		{
			if (Platform.PackSmall)
			{
				return Marshal.SizeOf(typeof(RemoteStorageUserVoteDetails_t.PackSmall));
			}
			return Marshal.SizeOf(typeof(RemoteStorageUserVoteDetails_t));
		}

		internal struct PackSmall
		{
			internal SteamNative.Result Result;

			internal ulong PublishedFileId;

			internal WorkshopVote Vote;

			public static implicit operator RemoteStorageUserVoteDetails_t(RemoteStorageUserVoteDetails_t.PackSmall d)
			{
				RemoteStorageUserVoteDetails_t remoteStorageUserVoteDetailsT = new RemoteStorageUserVoteDetails_t()
				{
					Result = d.Result,
					PublishedFileId = d.PublishedFileId,
					Vote = d.Vote
				};
				return remoteStorageUserVoteDetailsT;
			}
		}
	}
}