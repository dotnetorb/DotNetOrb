/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace Security
{
	[RepositoryID("IDL:omg.org/Security/OpaqueBuffer:1.0")]
	[Helper(typeof(OpaqueBufferHelper))]
	public partial class OpaqueBuffer: CORBA.IIDLEntity, IEquatable<Security.OpaqueBuffer>
	{
		[IdlName("OpaqueBuffer")]
		public byte[] Buffer { get; set; }
		[IdlName("OpaqueBuffer")]
		public uint Startpos { get; set; }
		[IdlName("OpaqueBuffer")]
		public uint Endpos { get; set; }

		public OpaqueBuffer()
		{
		}

		public OpaqueBuffer(OpaqueBuffer other)
		{
			Buffer = other.Buffer;
			Startpos = other.Startpos;
			Endpos = other.Endpos;
		}

		public OpaqueBuffer(byte[] buffer, uint startpos, uint endpos)
		{
			this.Buffer = buffer;
			this.Startpos = startpos;
			this.Endpos = endpos;
		}

		public bool Equals(Security.OpaqueBuffer? other)
		{
			if (other == null) return false;
			if (!Buffer.SequenceEqual(other.Buffer)) return false;
			if (!Startpos.Equals(other.Startpos)) return false;
			if (!Endpos.Equals(other.Endpos)) return false;
			return true;
		}
	}

}
