/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DynamicAny
{
	[IdlName("MustTruncate")]
	[RepositoryID("IDL:DynamicAny/MustTruncate:1.0")]
	[Helper(typeof(MustTruncateHelper))]
	public partial class MustTruncate: CORBA.UserException, CORBA.IIDLEntity, IEquatable<DynamicAny.MustTruncate>
	{
		public MustTruncate()
		{
		}

		public MustTruncate(string _msg): base(_msg)
		{
		}

		public MustTruncate(MustTruncate other)
		{
		}

		public bool Equals(DynamicAny.MustTruncate? other)
		{
			if (other == null) return false;
			return true;
		}
	}

}