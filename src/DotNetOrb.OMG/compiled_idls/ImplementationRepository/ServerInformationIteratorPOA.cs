/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace ImplementationRepository
{

	public abstract class ServerInformationIteratorPOA: PortableServer.Servant, CORBA.IInvokeHandler, IServerInformationIteratorOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static ServerInformationIteratorPOA()
		{
			_opsDict.Add("next_n", 0);
			_opsDict.Add("destroy", 1);
		}
		private string[] _ids = {"IDL:ImplementationRepository/ServerInformationIterator:1.0"};

		[IdlName("next_n")]
		public abstract bool NextN(uint howMany, out ImplementationRepository.ServerInformation[] servers);
		[IdlName("destroy")]
		public abstract void Destroy();

		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual ImplementationRepository.IServerInformationIterator _This()
		{
			return ImplementationRepository.ServerInformationIteratorHelper.Narrow(_ThisObject());
		}

		public virtual ImplementationRepository.IServerInformationIterator _This(CORBA.ORB orb)
		{
			return ImplementationRepository.ServerInformationIteratorHelper.Narrow(_ThisObject(orb));
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
							uint howMany;
							howMany = inputStream.ReadULong();
							outputStream = handler.CreateReply();
							var _result = NextN(howMany, out ImplementationRepository.ServerInformation[] servers);
							outputStream.WriteBoolean(_result);
							{
								outputStream.WriteLong(servers.Length);
								for (int i0 = 0; i0 < servers.Length; i0++)
								{
									ImplementationRepository.ServerInformationHelper.Write(outputStream, servers[i0]);
								}
							}
					}
					break;
					case 1:
					{
							outputStream = handler.CreateReply();
							Destroy();
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
