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
	[IdlName("GOA")]
	[RepositoryID("IDL:omg.org/PortableGroup/GOA:1.0")]
	[Helper(typeof(GOAHelper))]
	[Stub(typeof(_GOALocalBase))]
	public interface IGOA : CORBA.IIDLEntity, CORBA.ILocalInterface, IGOAOperations, PortableServer.IPOA
	{
	}
}
