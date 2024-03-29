/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace CORBA
{
	[RepositoryID("IDL:CORBA/Initializer:1.0")]
	[Helper(typeof(InitializerHelper))]
	public partial class Initializer: CORBA.IIDLEntity, IEquatable<CORBA.Initializer>
	{
		[IdlName("Initializer")]
		public CORBA.StructMember[] Members { get; set; }
		[IdlName("Initializer")]
		[WideChar(false)]
		public string Name { get; set; }

		public Initializer()
		{
		}

		public Initializer(Initializer other)
		{
			Members = other.Members;
			Name = other.Name;
		}

		public Initializer(CORBA.StructMember[] members, string name)
		{
			this.Members = members;
			this.Name = name;
		}

		public bool Equals(CORBA.Initializer? other)
		{
			if (other == null) return false;
			if (!Members.SequenceEqual(other.Members)) return false;
			if (!Name.Equals(other.Name)) return false;
			return true;
		}
	}

}
