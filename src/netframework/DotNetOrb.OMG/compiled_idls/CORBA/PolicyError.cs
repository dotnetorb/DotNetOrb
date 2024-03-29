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
	[IdlName("PolicyError")]
	[RepositoryID("IDL:CORBA/PolicyError:1.0")]
	[Helper(typeof(PolicyErrorHelper))]
	public partial class PolicyError: CORBA.UserException, CORBA.IIDLEntity, IEquatable<CORBA.PolicyError>
	{
		public PolicyError()
		{
		}

		public PolicyError(string _msg): base(_msg)
		{
		}

		public PolicyError(PolicyError other)
		{
			Reason = other.Reason;
		}

		public PolicyError(short reason, string _msg = ""): base(_msg)
		{
			this.Reason = reason;
		}

		public bool Equals(CORBA.PolicyError? other)
		{
			if (other == null) return false;
			if (!Reason.Equals(other.Reason)) return false;
			return true;
		}
		[IdlName("reason")]
		public short Reason { get; set; }
	}

}
