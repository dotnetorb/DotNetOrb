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
	public static class AuthenticationMethodListHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(AuthenticationMethodListHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(Security.AuthenticationMethodListHelper.Id(), "AuthenticationMethodList", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5)));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, uint[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static uint[] Extract(CORBA.Any any)
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
			return "IDL:omg.org/Security/AuthenticationMethodList:1.0";
		}

		public static uint[] Read(CORBA.IInputStream inputStream)
		{
			uint[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				var _array = new uint[_capacity0];
				inputStream.ReadULongArray(ref _array, 0, _capacity0);
				result = _array;
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, uint[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				outputStream.WriteULongArray(value, 0, value.Length);
			}
		}

	}
}
