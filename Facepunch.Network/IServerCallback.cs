using System;

namespace Network
{
	public interface IServerCallback
	{
		void OnDisconnected(string reason, Connection connection);

		void OnNetworkMessage(Message message);

		bool OnUnconnectedMessage(int type, Read read, uint ip, int port);
	}
}