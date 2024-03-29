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
	public interface ICurrentOperations : CORBA.ICurrentOperations
	{
		[IdlName("get_POA")]
		[ThrowsIdlException(typeof(PortableServer.Current.NoContext))]
		public PortableServer.IPOA GetPoa();
		[IdlName("get_object_id")]
		[ThrowsIdlException(typeof(PortableServer.Current.NoContext))]
		public byte[] GetObjectId();
		[IdlName("get_reference")]
		[ThrowsIdlException(typeof(PortableServer.Current.NoContext))]
		public CORBA.IObject GetReference();
		[IdlName("get_servant")]
		[ThrowsIdlException(typeof(PortableServer.Current.NoContext))]
		public PortableServer.Servant GetServant();
	}
}

