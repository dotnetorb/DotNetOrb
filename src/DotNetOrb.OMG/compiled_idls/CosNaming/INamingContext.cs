/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CosNaming
{
	[IdlName("NamingContext")]
	[RepositoryID("IDL:omg.org/CosNaming/NamingContext:1.0")]
	[Helper(typeof(NamingContextHelper))]
	[Stub(typeof(_NamingContextStub))]
	public interface INamingContext : CORBA.IIDLEntity, CORBA.IObject, INamingContextOperations
	{
	}
}

