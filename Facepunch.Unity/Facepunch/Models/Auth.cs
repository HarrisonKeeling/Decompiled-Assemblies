using System;

namespace Facepunch.Models
{
	public class Auth
	{
		public string Type;

		public string Id;

		public string Ticket;

		public string Name;

		public Auth()
		{
		}

		public static Auth Steam(byte[] ticket, ulong steamId, string username)
		{
			return new Auth()
			{
				Type = "steam",
				Name = username,
				Id = steamId.ToString(),
				Ticket = BitConverter.ToString(ticket).Replace("-", "")
			};
		}
	}
}