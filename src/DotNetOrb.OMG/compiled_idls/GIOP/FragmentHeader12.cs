/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace GIOP
{
	[RepositoryID("IDL:GIOP/FragmentHeader_1_2:1.0")]
	[Helper(typeof(FragmentHeader12Helper))]
	public partial class FragmentHeader12: CORBA.IIDLEntity, IEquatable<GIOP.FragmentHeader12>
	{
		[IdlName("FragmentHeader_1_2")]
		public uint RequestId { get; set; }

		public FragmentHeader12()
		{
		}

		public FragmentHeader12(FragmentHeader12 other)
		{
			RequestId = other.RequestId;
		}

		public FragmentHeader12(uint requestId)
		{
			this.RequestId = requestId;
		}

		public bool Equals(GIOP.FragmentHeader12? other)
		{
			if (other == null) return false;
			if (!RequestId.Equals(other.RequestId)) return false;
			return true;
		}
	}

}
