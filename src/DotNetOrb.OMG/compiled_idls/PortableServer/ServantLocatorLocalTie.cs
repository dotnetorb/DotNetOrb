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

	public class ServantLocatorLocalTie: _ServantLocatorLocalBase
	{
		public IServantLocatorOperations _OperationsDelegate { get; set; }

		public ServantLocatorLocalTie(IServantLocatorOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("preinvoke")]
		[ThrowsIdlException(typeof(PortableServer.ForwardRequest))]
		public override PortableServer.Servant Preinvoke(byte[] oid, PortableServer.IPOA adapter, [WideChar(false)] string operation, out PortableServer.ServantLocator.Cookie theCookie)
		{
			return _OperationsDelegate.Preinvoke(oid, adapter, operation, out theCookie);
		}
		[IdlName("postinvoke")]
		public override void Postinvoke(byte[] oid, PortableServer.IPOA adapter, [WideChar(false)] string operation, PortableServer.ServantLocator.Cookie theCookie, PortableServer.Servant theServant)
		{
			_OperationsDelegate.Postinvoke(oid, adapter, operation, theCookie, theServant);
		}
	}
}