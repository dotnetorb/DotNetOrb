/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace BiDirPolicy
{

	public abstract class BidirectionalPolicyPOA: PortableServer.Servant, CORBA.IInvokeHandler, IBidirectionalPolicyOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static BidirectionalPolicyPOA()
		{
			_opsDict.Add("_get_policy_type", 0);
			_opsDict.Add("copy", 1);
			_opsDict.Add("destroy", 2);
			_opsDict.Add("_get_value", 3);
		}
		private string[] _ids = {"IDL:omg.org/BiDirPolicy/BidirectionalPolicy:1.0","IDL:CORBA/Policy:1.0"};

		[IdlName("policy_type")]
		public abstract uint PolicyType 
		{
			get;
		}
		[IdlName("copy")]
		public abstract CORBA.IPolicy Copy();
		[IdlName("destroy")]
		public abstract void Destroy();
		[IdlName("value")]
		public abstract ushort Value 
		{
			get;
		}

		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual BiDirPolicy.IBidirectionalPolicy _This()
		{
			return BiDirPolicy.BidirectionalPolicyHelper.Narrow(_ThisObject());
		}

		public virtual BiDirPolicy.IBidirectionalPolicy _This(CORBA.ORB orb)
		{
			return BiDirPolicy.BidirectionalPolicyHelper.Narrow(_ThisObject(orb));
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
							outputStream.WriteULong(PolicyType);
					}
					break;
					case 1:
					{
							outputStream = handler.CreateReply();
							var _result = Copy();
							CORBA.PolicyHelper.Write(outputStream, _result);
					}
					break;
					case 2:
					{
							outputStream = handler.CreateReply();
							Destroy();
					}
					break;
					case 3:
					{
							outputStream = handler.CreateReply();
							outputStream.WriteUShort(Value);
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
