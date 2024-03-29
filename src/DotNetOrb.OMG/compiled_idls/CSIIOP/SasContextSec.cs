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
	[RepositoryID("IDL:CSIIOP/SAS_ContextSec:1.0")]
	[Helper(typeof(SasContextSecHelper))]
	public partial class SasContextSec: CORBA.IIDLEntity, IEquatable<CSIIOP.SasContextSec>
	{
		[IdlName("SAS_ContextSec")]
		public ushort TargetSupports { get; set; }
		[IdlName("SAS_ContextSec")]
		public ushort TargetRequires { get; set; }
		[IdlName("SAS_ContextSec")]
		public CSIIOP.ServiceConfiguration[] PrivilegeAuthorities { get; set; }
		[IdlName("SAS_ContextSec")]
		public byte[][] SupportedNamingMechanisms { get; set; }
		[IdlName("SAS_ContextSec")]
		public uint SupportedIdentityTypes { get; set; }

		public SasContextSec()
		{
		}

		public SasContextSec(SasContextSec other)
		{
			TargetSupports = other.TargetSupports;
			TargetRequires = other.TargetRequires;
			PrivilegeAuthorities = other.PrivilegeAuthorities;
			SupportedNamingMechanisms = other.SupportedNamingMechanisms;
			SupportedIdentityTypes = other.SupportedIdentityTypes;
		}

		public SasContextSec(ushort targetSupports, ushort targetRequires, CSIIOP.ServiceConfiguration[] privilegeAuthorities, byte[][] supportedNamingMechanisms, uint supportedIdentityTypes)
		{
			this.TargetSupports = targetSupports;
			this.TargetRequires = targetRequires;
			this.PrivilegeAuthorities = privilegeAuthorities;
			this.SupportedNamingMechanisms = supportedNamingMechanisms;
			this.SupportedIdentityTypes = supportedIdentityTypes;
		}

		public bool Equals(CSIIOP.SasContextSec? other)
		{
			if (other == null) return false;
			if (!TargetSupports.Equals(other.TargetSupports)) return false;
			if (!TargetRequires.Equals(other.TargetRequires)) return false;
			if (!PrivilegeAuthorities.SequenceEqual(other.PrivilegeAuthorities)) return false;
			if (!SupportedNamingMechanisms.SequenceEqual(other.SupportedNamingMechanisms)) return false;
			if (!SupportedIdentityTypes.Equals(other.SupportedIdentityTypes)) return false;
			return true;
		}
	}

}
