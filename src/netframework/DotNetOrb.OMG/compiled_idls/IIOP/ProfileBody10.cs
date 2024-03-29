/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace IIOP
{
	[RepositoryID("IDL:IIOP/ProfileBody_1_0:1.0")]
	[Helper(typeof(ProfileBody10Helper))]
	public partial class ProfileBody10: CORBA.IIDLEntity, IEquatable<IIOP.ProfileBody10>
	{
		[IdlName("ProfileBody_1_0")]
		public IIOP.Version IiopVersion { get; set; }
		[IdlName("ProfileBody_1_0")]
		[WideChar(false)]
		public string Host { get; set; }
		[IdlName("ProfileBody_1_0")]
		public ushort Port { get; set; }
		[IdlName("ProfileBody_1_0")]
		public byte[] ObjectKey { get; set; }

		public ProfileBody10()
		{
		}

		public ProfileBody10(ProfileBody10 other)
		{
			IiopVersion = other.IiopVersion;
			Host = other.Host;
			Port = other.Port;
			ObjectKey = other.ObjectKey;
		}

		public ProfileBody10(IIOP.Version iiopVersion, string host, ushort port, byte[] objectKey)
		{
			this.IiopVersion = iiopVersion;
			this.Host = host;
			this.Port = port;
			this.ObjectKey = objectKey;
		}

		public bool Equals(IIOP.ProfileBody10? other)
		{
			if (other == null) return false;
			if (!IiopVersion.Equals(other.IiopVersion)) return false;
			if (!Host.Equals(other.Host)) return false;
			if (!Port.Equals(other.Port)) return false;
			if (!ObjectKey.SequenceEqual(other.ObjectKey)) return false;
			return true;
		}
	}

}
