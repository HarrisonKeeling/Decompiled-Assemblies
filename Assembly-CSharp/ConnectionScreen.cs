using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ConnectionScreen : SingletonComponent<ConnectionScreen>
{
	public Text statusText;

	public GameObject disconnectButton;

	public GameObject retryButton;

	public ServerBrowserInfo browserInfo;

	public UnityEvent onShowConnectionScreen = new UnityEvent();

	public ConnectionScreen()
	{
	}
}