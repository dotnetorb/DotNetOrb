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
	public static class InitializerHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(InitializerHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CORBA.InitializerHelper.Id(), "Initializer", new CORBA.StructMember[] {new CORBA.StructMember("members", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.StructMemberHelper.Type()), null), new CORBA.StructMember("name", CORBA.ORB.Init().CreateStringTc(0), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.Initializer s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CORBA.Initializer Extract(CORBA.Any any)
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
			return "IDL:CORBA/Initializer:1.0";
		}

		public static CORBA.Initializer Read(CORBA.IInputStream inputStream)
		{
			var result = new CORBA.Initializer();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.Members = new CORBA.StructMember[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CORBA.StructMember _item0;
					_item0 = CORBA.StructMemberHelper.Read(inputStream);
					result.Members[i0] = _item0;
				}
			}
			result.Name = inputStream.ReadString();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.Initializer s)
		{
			{
				outputStream.WriteLong(s.Members.Length);
				for (int i0 = 0; i0 < s.Members.Length; i0++)
				{
					CORBA.StructMemberHelper.Write(outputStream, s.Members[i0]);
				}
			}
			outputStream.WriteString(s.Name);
		}

	}
}
