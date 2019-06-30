using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Facepunch.UI
{
	public class ESPPlayerInfo : MonoBehaviour
	{
		public Vector3 WorldOffset;

		public TextMeshProUGUI Text;

		public TextMeshProUGUI Image;

		public CanvasGroup @group;

		public Gradient gradientNormal;

		public Gradient gradientTeam;

		public Color TeamColor;

		public QueryVis visCheck;

		public BasePlayer Entity
		{
			get;
			set;
		}

		public ESPPlayerInfo()
		{
		}
	}
}