﻿using Cubizer.Net.Protocol.Serialization;

namespace Cubizer.Net.Protocol.Play.Serverbound
{
	public class UseItem : IPacketSerializable
	{
		public uint packetId
		{
			get
			{
				throw new System.NotImplementedException();
			}
		}

		public object Clone()
		{
			throw new System.NotImplementedException();
		}

		public void Deserialize(NetworkReader br)
		{
			throw new System.NotImplementedException();
		}

		public void Serialize(NetworkWrite bw)
		{
			throw new System.NotImplementedException();
		}
	}
}