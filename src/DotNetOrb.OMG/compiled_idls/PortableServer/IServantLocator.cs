/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{
	[IdlName("ServantLocator")]
	[RepositoryID("IDL:PortableServer/ServantLocator:1.0")]
	[Helper(typeof(ServantLocatorHelper))]
	[Stub(typeof(_ServantLocatorLocalBase))]
	public interface IServantLocator : CORBA.IIDLEntity, CORBA.ILocalInterface, IServantLocatorOperations, PortableServer.IServantManager
	{
	}
}

