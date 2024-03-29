/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{
	public interface IPOAManagerFactoryOperations
	{
		[IdlName("create_POAManager")]
		[ThrowsIdlException(typeof(PortableServer.POAManagerFactory.ManagerAlreadyExists))]
		[ThrowsIdlException(typeof(CORBA.PolicyError))]
		public PortableServer.IPOAManager CreatePOAManager([WideChar(false)] string id, CORBA.IPolicy[] policies);
		[IdlName("list")]
		public PortableServer.IPOAManager[] List();
		[IdlName("find")]
		public PortableServer.IPOAManager Find([WideChar(false)] string id);
	}
}

