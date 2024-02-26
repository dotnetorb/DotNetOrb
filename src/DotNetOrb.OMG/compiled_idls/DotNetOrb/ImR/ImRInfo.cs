/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace DotNetOrb.ImR
{
	[RepositoryID("IDL:DotNetOrb/ImR/ImRInfo:1.0")]
	[Helper(typeof(ImRInfoHelper))]
	public partial class ImRInfo: CORBA.IIDLEntity, IEquatable<DotNetOrb.ImR.ImRInfo>
	{
		[IdlName("ImRInfo")]
		[WideChar(false)]
		public string Host { get; set; }
		[IdlName("ImRInfo")]
		public uint Port { get; set; }

		public ImRInfo()
		{
		}

		public ImRInfo(ImRInfo other)
		{
			Host = other.Host;
			Port = other.Port;
		}

		public ImRInfo(string host, uint port)
		{
			this.Host = host;
			this.Port = port;
		}

		public bool Equals(DotNetOrb.ImR.ImRInfo? other)
		{
			if (other == null) return false;
			if (!Host.Equals(other.Host)) return false;
			if (!Port.Equals(other.Port)) return false;
			return true;
		}
	}

}
