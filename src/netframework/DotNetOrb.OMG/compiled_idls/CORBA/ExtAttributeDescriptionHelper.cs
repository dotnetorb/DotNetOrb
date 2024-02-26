/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public static class ExtAttributeDescriptionHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ExtAttributeDescriptionHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CORBA.ExtAttributeDescriptionHelper.Id(), "ExtAttributeDescription", new CORBA.StructMember[] {new CORBA.StructMember("name", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("id", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("defined_in", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("version", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("type", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 12), null), new CORBA.StructMember("mode", CORBA.AttributeModeHelper.Type(), null), new CORBA.StructMember("get_exceptions", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ExceptionDescriptionHelper.Type()), null), new CORBA.StructMember("put_exceptions", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ExceptionDescriptionHelper.Type()), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.ExtAttributeDescription s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CORBA.ExtAttributeDescription Extract(CORBA.Any any)
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
			return "IDL:CORBA/ExtAttributeDescription:1.0";
		}

		public static CORBA.ExtAttributeDescription Read(CORBA.IInputStream inputStream)
		{
			var result = new CORBA.ExtAttributeDescription();
			result.Name = inputStream.ReadString();
			result.Id = inputStream.ReadString();
			result.DefinedIn = inputStream.ReadString();
			result.Version = inputStream.ReadString();
			result.Type = inputStream.ReadTypeCode();
			result.Mode = CORBA.AttributeModeHelper.Read(inputStream);
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.GetExceptions = new CORBA.ExceptionDescription[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CORBA.ExceptionDescription _item0;
					_item0 = CORBA.ExceptionDescriptionHelper.Read(inputStream);
					result.GetExceptions[i0] = _item0;
				}
			}
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.PutExceptions = new CORBA.ExceptionDescription[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CORBA.ExceptionDescription _item0;
					_item0 = CORBA.ExceptionDescriptionHelper.Read(inputStream);
					result.PutExceptions[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.ExtAttributeDescription s)
		{
			outputStream.WriteString(s.Name);
			outputStream.WriteString(s.Id);
			outputStream.WriteString(s.DefinedIn);
			outputStream.WriteString(s.Version);
			outputStream.WriteTypeCode(s.Type);
			CORBA.AttributeModeHelper.Write(outputStream, s.Mode);
			{
				outputStream.WriteLong(s.GetExceptions.Length);
				for (int i0 = 0; i0 < s.GetExceptions.Length; i0++)
				{
					CORBA.ExceptionDescriptionHelper.Write(outputStream, s.GetExceptions[i0]);
				}
			}
			{
				outputStream.WriteLong(s.PutExceptions.Length);
				for (int i0 = 0; i0 < s.PutExceptions.Length; i0++)
				{
					CORBA.ExceptionDescriptionHelper.Write(outputStream, s.PutExceptions[i0]);
				}
			}
		}

	}
}
