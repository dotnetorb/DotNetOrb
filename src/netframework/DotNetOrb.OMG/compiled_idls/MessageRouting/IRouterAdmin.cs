/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:35
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace MessageRouting
{
	[IdlName("RouterAdmin")]
	[RepositoryID("IDL:MessageRouting/RouterAdmin:1.0")]
	[Helper(typeof(RouterAdminHelper))]
	[Stub(typeof(_RouterAdminStub))]
	public interface IRouterAdmin : CORBA.IIDLEntity, CORBA.IObject, IRouterAdminOperations
	{
	}
}
