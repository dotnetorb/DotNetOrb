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
	[RepositoryID("IDL:omg.org/Security/ExtensibleFamily:1.0")]
	[Helper(typeof(ExtensibleFamilyHelper))]
	public partial class ExtensibleFamily: CORBA.IIDLEntity, IEquatable<Security.ExtensibleFamily>
	{
		[IdlName("ExtensibleFamily")]
		public ushort FamilyDefiner { get; set; }
		[IdlName("ExtensibleFamily")]
		public ushort Family { get; set; }

		public ExtensibleFamily()
		{
		}

		public ExtensibleFamily(ExtensibleFamily other)
		{
			FamilyDefiner = other.FamilyDefiner;
			Family = other.Family;
		}

		public ExtensibleFamily(ushort familyDefiner, ushort family)
		{
			this.FamilyDefiner = familyDefiner;
			this.Family = family;
		}

		public bool Equals(Security.ExtensibleFamily? other)
		{
			if (other == null) return false;
			if (!FamilyDefiner.Equals(other.FamilyDefiner)) return false;
			if (!Family.Equals(other.Family)) return false;
			return true;
		}
	}

}
