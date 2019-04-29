using Facepunch.Steamworks;
using Facepunch.Steamworks.Interop;
using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	internal struct RemoteStoragePublishedFileUnsubscribed_t
	{
		internal const int CallbackId = 1322;

		internal ulong PublishedFileId;

		internal uint AppID;

		internal static RemoteStoragePublishedFileUnsubscribed_t FromPointer(IntPtr p)
		{
			if (!Platform.PackSmall)
			{
				return (RemoteStoragePublishedFileUnsubscribed_t)Marshal.PtrToStructure(p, typeof(RemoteStoragePublishedFileUnsubscribed_t));
			}
			return (RemoteStoragePublishedFileUnsubscribed_t.PackSmall)Marshal.PtrToStructure(p, typeof(RemoteStoragePublishedFileUnsubscribed_t.PackSmall));
		}

		[MonoPInvokeCallback]
		internal static int OnGetSize()
		{
			return RemoteStoragePublishedFileUnsubscribed_t.StructSize();
		}

		[MonoPInvokeCallback]
		internal static int OnGetSizeThis(IntPtr self)
		{
			return RemoteStoragePublishedFileUnsubscribed_t.OnGetSize();
		}

		[MonoPInvokeCallback]
		internal static void OnResult(IntPtr param)
		{
			RemoteStoragePublishedFileUnsubscribed_t.OnResultWithInfo(param, false, (long)0);
		}

		[MonoPInvokeCallback]
		internal static void OnResultThis(IntPtr self, IntPtr param)
		{
			RemoteStoragePublishedFileUnsubscribed_t.OnResult(param);
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call)
		{
			if (failure)
			{
				return;
			}
			RemoteStoragePublishedFileUnsubscribed_t remoteStoragePublishedFileUnsubscribedT = RemoteStoragePublishedFileUnsubscribed_t.FromPointer(param);
			if (Client.Instance != null)
			{
				Client.Instance.OnCallback<RemoteStoragePublishedFileUnsubscribed_t>(remoteStoragePublishedFileUnsubscribedT);
			}
			if (Server.Instance != null)
			{
				Server.Instance.OnCallback<RemoteStoragePublishedFileUnsubscribed_t>(remoteStoragePublishedFileUnsubscribedT);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call)
		{
			RemoteStoragePublishedFileUnsubscribed_t.OnResultWithInfo(param, failure, call);
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
						ResultA = new Callback.VTableThis.ResultD(RemoteStoragePublishedFileUnsubscribed_t.OnResultThis),
						ResultB = new Callback.VTableThis.ResultWithInfoD(RemoteStoragePublishedFileUnsubscribed_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableThis.GetSizeD(RemoteStoragePublishedFileUnsubscribed_t.OnGetSizeThis)
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
						ResultA = new Callback.VTableWinThis.ResultD(RemoteStoragePublishedFileUnsubscribed_t.OnResultThis),
						ResultB = new Callback.VTableWinThis.ResultWithInfoD(RemoteStoragePublishedFileUnsubscribed_t.OnResultWithInfoThis),
						GetSize = new Callback.VTableWinThis.GetSizeD(RemoteStoragePublishedFileUnsubscribed_t.OnGetSizeThis)
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
					ResultA = new Callback.VTable.ResultD(RemoteStoragePublishedFileUnsubscribed_t.OnResult),
					ResultB = new Callback.VTable.ResultWithInfoD(RemoteStoragePublishedFileUnsubscribed_t.OnResultWithInfo),
					GetSize = new Callback.VTable.GetSizeD(RemoteStoragePublishedFileUnsubscribed_t.OnGetSize)
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
					ResultA = new Callback.VTableWin.ResultD(RemoteStoragePublishedFileUnsubscribed_t.OnResult),
					ResultB = new Callback.VTableWin.ResultWithInfoD(RemoteStoragePublishedFileUnsubscribed_t.OnResultWithInfo),
					GetSize = new Callback.VTableWin.GetSizeD(RemoteStoragePublishedFileUnsubscribed_t.OnGetSize)
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
				CallbackId = 1322
			};
			callbackHandle.PinnedCallback = GCHandle.Alloc(callback, GCHandleType.Pinned);
			steamworks.native.api.SteamAPI_RegisterCallback(callbackHandle.PinnedCallback.AddrOfPinnedObject(), 1322);
			steamworks.RegisterCallbackHandle(callbackHandle);
		}

		internal static int StructSize()
		{
			if (Platform.PackSmall)
			{
				return Marshal.SizeOf(typeof(RemoteStoragePublishedFileUnsubscribed_t.PackSmall));
			}
			return Marshal.SizeOf(typeof(RemoteStoragePublishedFileUnsubscribed_t));
		}

		internal struct PackSmall
		{
			internal ulong PublishedFileId;

			internal uint AppID;

			public static implicit operator RemoteStoragePublishedFileUnsubscribed_t(RemoteStoragePublishedFileUnsubscribed_t.PackSmall d)
			{
				RemoteStoragePublishedFileUnsubscribed_t remoteStoragePublishedFileUnsubscribedT = new RemoteStoragePublishedFileUnsubscribed_t()
				{
					PublishedFileId = d.PublishedFileId,
					AppID = d.AppID
				};
				return remoteStoragePublishedFileUnsubscribedT;
			}
		}
	}
}