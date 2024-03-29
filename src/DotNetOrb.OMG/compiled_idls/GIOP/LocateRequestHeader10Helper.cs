/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace GIOP
{
	public static class LocateRequestHeader10Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(LocateRequestHeader10Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(GIOP.LocateRequestHeader10Helper.Id(), "LocateRequestHeader_1_0", new CORBA.StructMember[] {new CORBA.StructMember("request_id", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), null), new CORBA.StructMember("object_key", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.LocateRequestHeader10 s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static GIOP.LocateRequestHeader10 Extract(CORBA.Any any)
		{
			var inputStream = any.CreateInputStream();
			try
			{
				return Read(inputStream);
			}
			finally
			{
				inputStream.Close();
			}
		}

		public static string Id()
		{
			return "IDL:GIOP/LocateRequestHeader_1_0:1.0";
		}

		public static GIOP.LocateRequestHeader10 Read(CORBA.IInputStream inputStream)
		{
			var result = new GIOP.LocateRequestHeader10();
			result.RequestId = inputStream.ReadULong();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				var _array = new byte[_capacity0];
				inputStream.ReadOctetArray(ref _array, 0, _capacity0);
				result.ObjectKey = _array;
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.LocateRequestHeader10 s)
		{
			outputStream.WriteULong(s.RequestId);
			{
				outputStream.WriteLong(s.ObjectKey.Length);
				outputStream.WriteOctetArray(s.ObjectKey, 0, s.ObjectKey.Length);
			}
		}

	}
}
