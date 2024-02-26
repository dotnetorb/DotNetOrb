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
	public abstract class _POAManagerFactoryLocalBase: CORBA.LocalObject, IPOAManagerFactory
	{
		private string[] _ids = {"IDL:PortableServer/POAManagerFactory:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("create_POAManager")]
		[ThrowsIdlException(typeof(PortableServer.POAManagerFactory.ManagerAlreadyExists))]
		[ThrowsIdlException(typeof(CORBA.PolicyError))]
		public abstract PortableServer.IPOAManager CreatePOAManager([WideChar(false)] string id, CORBA.IPolicy[] policies);
		[IdlName("list")]
		public abstract PortableServer.IPOAManager[] List();
		[IdlName("find")]
		public abstract PortableServer.IPOAManager Find([WideChar(false)] string id);
	}

}