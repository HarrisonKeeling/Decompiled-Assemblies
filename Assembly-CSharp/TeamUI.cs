using System;
using UnityEngine;
using UnityEngine.UI;

public class TeamUI : MonoBehaviour
{
	public RectTransform MemberPanel;

	public GameObject memberEntryPrefab;

	public TeamMemberElement[] elements;

	public GameObject NoTeamPanel;

	public GameObject TeamPanel;

	public GameObject LeaveTeamButton;

	public GameObject InviteAcceptPanel;

	public Text inviteText;

	public static bool dirty;

	[NonSerialized]
	public static ulong pendingTeamID;

	[NonSerialized]
	public static string pendingTeamLeaderName;

	static TeamUI()
	{
		TeamUI.dirty = true;
	}

	public TeamUI()
	{
	}
}