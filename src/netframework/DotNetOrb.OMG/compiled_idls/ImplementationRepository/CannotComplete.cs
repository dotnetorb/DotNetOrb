/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace ImplementationRepository
{
	[IdlName("CannotComplete")]
	[RepositoryID("IDL:ImplementationRepository/CannotComplete:1.0")]
	[Helper(typeof(CannotCompleteHelper))]
	public partial class CannotComplete: CORBA.UserException, CORBA.IIDLEntity, IEquatable<ImplementationRepository.CannotComplete>
	{
		public CannotComplete()
		{
		}

		public CannotComplete(string _msg): base(_msg)
		{
		}

		public CannotComplete(CannotComplete other)
		{
			Reason = other.Reason;
		}

		public CannotComplete(string reason, string _msg = ""): base(_msg)
		{
			this.Reason = reason;
		}

		public bool Equals(ImplementationRepository.CannotComplete? other)
		{
			if (other == null) return false;
			if (!Reason.Equals(other.Reason)) return false;
			return true;
		}
		[IdlName("reason")]
		[WideChar(false)]
		public string Reason { get; set; }
	}

}
