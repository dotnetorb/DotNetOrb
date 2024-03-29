/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Security
{
	public static class MechanismTypeListHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(MechanismTypeListHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(Security.MechanismTypeListHelper.Id(), "MechanismTypeList", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().CreateStringTc(0)));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, string[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static string[] Extract(CORBA.Any any)
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
			return "IDL:omg.org/Security/MechanismTypeList:1.0";
		}

		public static string[] Read(CORBA.IInputStream inputStream)
		{
			string[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result = new string[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					string _item0;
					_item0 = inputStream.ReadString();
					result[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, string[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				for (int i0 = 0; i0 < value.Length; i0++)
				{
					outputStream.WriteString(value[i0]);
				}
			}
		}

	}
}
