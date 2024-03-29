/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CSI
{
	public static class CompleteEstablishContextHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(CompleteEstablishContextHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CSI.CompleteEstablishContextHelper.Id(), "CompleteEstablishContext", new CORBA.StructMember[] {new CORBA.StructMember("client_context_id", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 24), null), new CORBA.StructMember("context_stateful", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 8), null), new CORBA.StructMember("final_context_token", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CSI.CompleteEstablishContext s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CSI.CompleteEstablishContext Extract(CORBA.Any any)
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
			return "IDL:CSI/CompleteEstablishContext:1.0";
		}

		public static CSI.CompleteEstablishContext Read(CORBA.IInputStream inputStream)
		{
			var result = new CSI.CompleteEstablishContext();
			result.ClientContextId = inputStream.ReadULongLong();
			result.ContextStateful = inputStream.ReadBoolean();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				var _array = new byte[_capacity0];
				inputStream.ReadOctetArray(ref _array, 0, _capacity0);
				result.FinalContextToken = _array;
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CSI.CompleteEstablishContext s)
		{
			outputStream.WriteULongLong(s.ClientContextId);
			outputStream.WriteBoolean(s.ContextStateful);
			{
				outputStream.WriteLong(s.FinalContextToken.Length);
				outputStream.WriteOctetArray(s.FinalContextToken, 0, s.FinalContextToken.Length);
			}
		}

	}
}
