/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DynamicAny
{
	public static class AnySeqHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(AnySeqHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(DynamicAny.AnySeqHelper.Id(), "AnySeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 11)));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.Any[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static CORBA.Any[] Extract(CORBA.Any any)
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
			return "IDL:DynamicAny/AnySeq:1.0";
		}

		public static CORBA.Any[] Read(CORBA.IInputStream inputStream)
		{
			CORBA.Any[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result = new CORBA.Any[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CORBA.Any _item0;
					_item0 = inputStream.ReadAny();
					result[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.Any[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				for (int i0 = 0; i0 < value.Length; i0++)
				{
					outputStream.WriteAny(value[i0]);
				}
			}
		}

	}
}
