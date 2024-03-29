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
	public static class RequestMessageHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(RequestMessageHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(MessageRouting.RequestMessageHelper.Id(), "RequestMessage", new CORBA.StructMember[] {new CORBA.StructMember("giop_version", GIOP.VersionHelper.Type(), null), new CORBA.StructMember("service_contexts", CORBA.ORB.Init().CreateSequenceTc(0, IOP.ServiceContextHelper.Type()), null), new CORBA.StructMember("response_flags", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10), null), new CORBA.StructMember("reserved", CORBA.ORB.Init().CreateArrayTc(3, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null), new CORBA.StructMember("object_key", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null), new CORBA.StructMember("operation", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("body", MessageRouting.MessageBodyHelper.Type(), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, MessageRouting.RequestMessage s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static MessageRouting.RequestMessage Extract(CORBA.Any any)
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
			return "IDL:MessageRouting/RequestMessage:1.0";
		}

		public static MessageRouting.RequestMessage Read(CORBA.IInputStream inputStream)
		{
			var result = new MessageRouting.RequestMessage();
			result.GiopVersion = GIOP.VersionHelper.Read(inputStream);
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.ServiceContexts = new IOP.ServiceContext[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					IOP.ServiceContext _item0;
					_item0 = IOP.ServiceContextHelper.Read(inputStream);
					result.ServiceContexts[i0] = _item0;
				}
			}
			result.ResponseFlags = inputStream.ReadOctet();
			result.Reserved = new byte[3];
			{
				for (int i0 = 0; i0 < 3; i0++)
				{
					result.Reserved[i0] = inputStream.ReadOctet();
				}
			}
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
			result.Operation = inputStream.ReadString();
			result.Body = MessageRouting.MessageBodyHelper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, MessageRouting.RequestMessage s)
		{
			GIOP.VersionHelper.Write(outputStream, s.GiopVersion);
			{
				outputStream.WriteLong(s.ServiceContexts.Length);
				for (int i0 = 0; i0 < s.ServiceContexts.Length; i0++)
				{
					IOP.ServiceContextHelper.Write(outputStream, s.ServiceContexts[i0]);
				}
			}
			outputStream.WriteOctet(s.ResponseFlags);
			if (s.Reserved.Length < 3)			{
				throw new CORBA.Marshal($"Incorrect array size {s.Reserved.Length}, expecting 3");
			}
			for (int i0 = 0; i0 < 3; i0++)
			{
				outputStream.WriteOctet(s.Reserved[i0]);
			}
			{
				outputStream.WriteLong(s.ObjectKey.Length);
				outputStream.WriteOctetArray(s.ObjectKey, 0, s.ObjectKey.Length);
			}
			outputStream.WriteString(s.Operation);
			MessageRouting.MessageBodyHelper.Write(outputStream, s.Body);
		}

	}
}
