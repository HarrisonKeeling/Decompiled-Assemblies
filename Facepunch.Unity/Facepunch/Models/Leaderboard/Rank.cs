using System;

namespace Facepunch.Models.Leaderboard
{
	public class Rank
	{
		public float Score;

		public int GlobalCount;

		public int GlobalRank;

		public string Country;

		public int CountryCount;

		public int CountryRank;

		public string City;

		public int CityCount;

		public int CityRank;

		public int FriendRank;

		public DateTime Created;

		public Rank()
		{
		}
	}
}