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
	[IdlName("ServerActiveStatus")]
	[RepositoryID("IDL:ImplementationRepository/ServerActiveStatus:1.0")]
	[Helper(typeof(ServerActiveStatusHelper))]
	public enum ServerActiveStatus
	{
		[IdlName("ACTIVE_MAYBE")]
		ACTIVE_MAYBE = 0,
		[IdlName("ACTIVE_YES")]
		ACTIVE_YES = 1,
		[IdlName("ACTIVE_NO")]
		ACTIVE_NO = 2,
	}

}
