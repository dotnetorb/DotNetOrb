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
	public abstract partial class ServantLocator : CORBA.Object, PortableServer.IServantLocator
	{
		[IdlName("preinvoke")]
		[ThrowsIdlException(typeof(PortableServer.ForwardRequest))]
		public abstract PortableServer.Servant Preinvoke(byte[] oid, PortableServer.IPOA adapter, [WideChar(false)] string operation, out PortableServer.ServantLocator.Cookie theCookie);
		[IdlName("postinvoke")]
		public abstract void Postinvoke(byte[] oid, PortableServer.IPOA adapter, [WideChar(false)] string operation, PortableServer.ServantLocator.Cookie theCookie, PortableServer.Servant theServant);
	}
}

