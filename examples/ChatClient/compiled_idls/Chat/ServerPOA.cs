/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Chat
{

	public abstract class ServerPOA: PortableServer.Servant, CORBA.IInvokeHandler, IServerOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static ServerPOA()
		{
			_opsDict.Add("_get_Name", 0);
			_opsDict.Add("RegisterUser", 1);
			_opsDict.Add("UnregisterUser", 2);
			_opsDict.Add("BroadcastMessage", 3);
		}
		private string[] _ids = {"IDL:Chat/Server:1.0"};

		[IdlName("Name")]
		[WideChar(false)]
		public abstract string Name 
		{
			get;
		}
		[IdlName("RegisterUser")]
		[ThrowsIdlException(typeof(Chat.MaxUsersReached))]
		public abstract bool RegisterUser(Chat.IClient clientRef, out int sessionId);
		[IdlName("UnregisterUser")]
		public abstract void UnregisterUser(int sessionId);
		[IdlName("BroadcastMessage")]
		[ThrowsIdlException(typeof(Chat.UserNotAuthenticated))]
		public abstract void BroadcastMessage(int sessionId, Chat.Message msg);

		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual Chat.IServer _This()
		{
			return Chat.ServerHelper.Narrow(_ThisObject());
		}

		public virtual Chat.IServer _This(CORBA.ORB orb)
		{
			return Chat.ServerHelper.Narrow(_ThisObject(orb));
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
							outputStream = handler.CreateReply();
							outputStream.WriteString(Name);
					}
					break;
					case 1:
					{
						try
						{
							Chat.IClient clientRef;
							clientRef = Chat.ClientHelper.Read(inputStream);
							outputStream = handler.CreateReply();
							var _result = RegisterUser(clientRef, out int sessionId);
							outputStream.WriteBoolean(_result);
							outputStream.WriteLong(sessionId);
						}
						catch(Chat.MaxUsersReached ex)
						{
							outputStream = handler.CreateExceptionReply();
							Chat.MaxUsersReachedHelper.Write(outputStream, ex);
						}
					}
					break;
					case 2:
					{
							int sessionId;
							sessionId = inputStream.ReadLong();
							outputStream = handler.CreateReply();
							UnregisterUser(sessionId);
					}
					break;
					case 3:
					{
						try
						{
							int sessionId;
							sessionId = inputStream.ReadLong();
							Chat.Message msg;
							msg = Chat.MessageHelper.Read(inputStream);
							outputStream = handler.CreateReply();
							BroadcastMessage(sessionId,msg);
						}
						catch(Chat.UserNotAuthenticated ex)
						{
							outputStream = handler.CreateExceptionReply();
							Chat.UserNotAuthenticatedHelper.Write(outputStream, ex);
						}
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
