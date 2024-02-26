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

	public abstract class ReplyHandlerPOA: PortableServer.Servant, CORBA.IInvokeHandler, IReplyHandlerOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static ReplyHandlerPOA()
		{
		}
		private string[] _ids = {"IDL:Messaging/ReplyHandler:1.0"};


		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual Messaging.IReplyHandler _This()
		{
			return Messaging.ReplyHandlerHelper.Narrow(_ThisObject());
		}

		public virtual Messaging.IReplyHandler _This(CORBA.ORB orb)
		{
			return Messaging.ReplyHandlerHelper.Narrow(_ThisObject(orb));
		}

		public CORBA.IOutputStream _Invoke(string method, CORBA.IInputStream inputStream, CORBA.IResponseHandler handler)
		{
			CORBA.IOutputStream outputStream = null;
			int opIndex;
			if (_opsDict.TryGetValue(method, out opIndex))
			{
				switch (opIndex)
				{
				}
				return outputStream;
			}
			else
			{
				throw new CORBA.BadOperation(method + " not found");
			}
		}
	}
}