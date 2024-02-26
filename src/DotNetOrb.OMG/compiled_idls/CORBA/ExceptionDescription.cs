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
	[RepositoryID("IDL:CORBA/ExceptionDescription:1.0")]
	[Helper(typeof(ExceptionDescriptionHelper))]
	public partial class ExceptionDescription: CORBA.IIDLEntity, IEquatable<CORBA.ExceptionDescription>
	{
		[IdlName("ExceptionDescription")]
		[WideChar(false)]
		public string Name { get; set; }
		[IdlName("ExceptionDescription")]
		[WideChar(false)]
		public string Id { get; set; }
		[IdlName("ExceptionDescription")]
		[WideChar(false)]
		public string DefinedIn { get; set; }
		[IdlName("ExceptionDescription")]
		[WideChar(false)]
		public string Version { get; set; }
		[IdlName("ExceptionDescription")]
		public CORBA.TypeCode Type { get; set; }

		public ExceptionDescription()
		{
		}

		public ExceptionDescription(ExceptionDescription other)
		{
			Name = other.Name;
			Id = other.Id;
			DefinedIn = other.DefinedIn;
			Version = other.Version;
			Type = other.Type;
		}

		public ExceptionDescription(string name, string id, string definedIn, string version, CORBA.TypeCode type)
		{
			this.Name = name;
			this.Id = id;
			this.DefinedIn = definedIn;
			this.Version = version;
			this.Type = type;
		}

		public bool Equals(CORBA.ExceptionDescription? other)
		{
			if (other == null) return false;
			if (!Name.Equals(other.Name)) return false;
			if (!Id.Equals(other.Id)) return false;
			if (!DefinedIn.Equals(other.DefinedIn)) return false;
			if (!Version.Equals(other.Version)) return false;
			if (!Type.Equals(other.Type)) return false;
			return true;
		}
	}

}
