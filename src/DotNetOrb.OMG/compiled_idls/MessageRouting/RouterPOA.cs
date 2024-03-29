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

	public abstract class RouterPOA: PortableServer.Servant, CORBA.IInvokeHandler, IRouterOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static RouterPOA()
		{
			_opsDict.Add("send_request", 0);
			_opsDict.Add("send_multiple_requests", 1);
			_opsDict.Add("_get_admin", 2);
		}
		private string[] _ids = {"IDL:MessageRouting/Router:1.0"};

		[IdlName("send_request")]
		public abstract void SendRequest(MessageRouting.RequestInfo req);
		[IdlName("send_multiple_requests")]
		public abstract void SendMultipleRequests(MessageRouting.RequestInfo[] reqSeq);
		[IdlName("admin")]
		public abstract MessageRouting.IRouterAdmin Admin 
		{
			get;
		}

		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual MessageRouting.IRouter _This()
		{
			return MessageRouting.RouterHelper.Narrow(_ThisObject());
		}

		public virtual MessageRouting.IRouter _This(CORBA.ORB orb)
		{
			return MessageRouting.RouterHelper.Narrow(_ThisObject(orb));
		}

		public CORBA.IOutputStream _Invoke(string method, CORBA.IInputStream inputStream, CORBA.IResponseHandler handler)
		{
			CORBA.IOutputStream outputStream = null;
			int opIndex;
			if (_opsDict.TryGetValue(method, out opIndex))
			{
				switch (opIndex)
				{
					case 0:
					{
							MessageRouting.RequestInfo req;
							req = MessageRouting.RequestInfoHelper.Read(inputStream);
							outputStream = handler.CreateReply();
							SendRequest(req);
					}
					break;
					case 1:
					{
							MessageRouting.RequestInfo[] reqSeq;
							{
								var _capacity0 = inputStream.ReadLong();
								if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
								{
									throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
								}
								reqSeq = new MessageRouting.RequestInfo[_capacity0];
								for (int i0 = 0; i0 < _capacity0; i0++)
								{
									MessageRouting.RequestInfo _item0;
									_item0 = MessageRouting.RequestInfoHelper.Read(inputStream);
									reqSeq[i0] = _item0;
								}
							}
							outputStream = handler.CreateReply();
							SendMultipleRequests(reqSeq);
					}
					break;
					case 2:
					{
							outputStream = handler.CreateReply();
							MessageRouting.RouterAdminHelper.Write(outputStream, Admin);
					}
					break;
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
