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
	[IdlName("AlreadyRegistered")]
	[RepositoryID("IDL:ImplementationRepository/AlreadyRegistered:1.0")]
	[Helper(typeof(AlreadyRegisteredHelper))]
	public partial class AlreadyRegistered: CORBA.UserException, CORBA.IIDLEntity, IEquatable<ImplementationRepository.AlreadyRegistered>
	{
		public AlreadyRegistered()
		{
		}

		public AlreadyRegistered(string _msg): base(_msg)
		{
		}

		public AlreadyRegistered(AlreadyRegistered other)
		{
		}

		public bool Equals(ImplementationRepository.AlreadyRegistered? other)
		{
			if (other == null) return false;
			return true;
		}
	}

}
