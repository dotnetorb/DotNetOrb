/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{
	[IdlName("ObjectGroupNotFound")]
	[RepositoryID("IDL:omg.org/PortableGroup/ObjectGroupNotFound:1.0")]
	[Helper(typeof(ObjectGroupNotFoundHelper))]
	public partial class ObjectGroupNotFound: CORBA.UserException, CORBA.IIDLEntity, IEquatable<PortableGroup.ObjectGroupNotFound>
	{
		public ObjectGroupNotFound()
		{
		}

		public ObjectGroupNotFound(string _msg): base(_msg)
		{
		}

		public ObjectGroupNotFound(ObjectGroupNotFound other)
		{
		}

		public bool Equals(PortableGroup.ObjectGroupNotFound? other)
		{
			if (other == null) return false;
			return true;
		}
	}

}
