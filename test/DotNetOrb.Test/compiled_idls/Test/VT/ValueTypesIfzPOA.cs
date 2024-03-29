/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Test.VT
{

	public abstract class ValueTypesIfzPOA: PortableServer.Servant, CORBA.IInvokeHandler, IValueTypesIfzOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static ValueTypesIfzPOA()
		{
			_opsDict.Add("GetRecord", 0);
		}
		private string[] _ids = {"IDL:Test/VT/ValueTypesIfz:1.0"};

		[IdlName("GetRecord")]
		public abstract Test.VT.ManagerRecord GetRecord(Test.VT.ManagerRecord record);

		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual Test.VT.IValueTypesIfz _This()
		{
			return Test.VT.ValueTypesIfzHelper.Narrow(_ThisObject());
		}

		public virtual Test.VT.IValueTypesIfz _This(CORBA.ORB orb)
		{
			return Test.VT.ValueTypesIfzHelper.Narrow(_ThisObject(orb));
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
							Test.VT.ManagerRecord record;
							record = ManagerRecordHelper.Read(inputStream);
							outputStream = handler.CreateReply();
							var _result = GetRecord(record);
							ManagerRecordHelper.Write(outputStream, _result);
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
