/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:35
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Messaging
{

	public class ReplyHandlerPOATie: ReplyHandlerPOA
	{
		public IReplyHandlerOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public ReplyHandlerPOATie(IReplyHandlerOperations d)
		{
			_OperationsDelegate = d;
		}

		public ReplyHandlerPOATie(IReplyHandlerOperations d, PortableServer.POA poa)
		{
			_OperationsDelegate = d;
			_poa = poa;
		}

		public override PortableServer.IPOA _DefaultPOA()
		{
			if (_poa != null)
			{
				return _poa;
			}
			return base._DefaultPOA();
		}

		public override Messaging.IReplyHandler _This()
		{
			return Messaging.ReplyHandlerHelper.Narrow(_ThisObject());
		}

		public override Messaging.IReplyHandler _This(CORBA.ORB orb)
		{
			return Messaging.ReplyHandlerHelper.Narrow(_ThisObject(orb));
		}

	}
}
