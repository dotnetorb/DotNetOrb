/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace CSIIOP
{
	[RepositoryID("IDL:CSIIOP/TransportAddress:1.0")]
	[Helper(typeof(TransportAddressHelper))]
	public partial class TransportAddress: CORBA.IIDLEntity, IEquatable<CSIIOP.TransportAddress>
	{
		[IdlName("TransportAddress")]
		[WideChar(false)]
		public string HostName { get; set; }
		[IdlName("TransportAddress")]
		public ushort Port { get; set; }

		public TransportAddress()
		{
		}

		public TransportAddress(TransportAddress other)
		{
			HostName = other.HostName;
			Port = other.Port;
		}

		public TransportAddress(string hostName, ushort port)
		{
			this.HostName = hostName;
			this.Port = port;
		}

		public bool Equals(CSIIOP.TransportAddress? other)
		{
			if (other == null) return false;
			if (!HostName.Equals(other.HostName)) return false;
			if (!Port.Equals(other.Port)) return false;
			return true;
		}
	}

}
