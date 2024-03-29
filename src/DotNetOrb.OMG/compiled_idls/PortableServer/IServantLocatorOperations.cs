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
	public interface IServantLocatorOperations : PortableServer.IServantManagerOperations
	{
		[IdlName("preinvoke")]
		[ThrowsIdlException(typeof(PortableServer.ForwardRequest))]
		public PortableServer.Servant Preinvoke(byte[] oid, PortableServer.IPOA adapter, [WideChar(false)] string operation, out PortableServer.ServantLocator.Cookie theCookie);
		[IdlName("postinvoke")]
		public void Postinvoke(byte[] oid, PortableServer.IPOA adapter, [WideChar(false)] string operation, PortableServer.ServantLocator.Cookie theCookie, PortableServer.Servant theServant);
	}
}

