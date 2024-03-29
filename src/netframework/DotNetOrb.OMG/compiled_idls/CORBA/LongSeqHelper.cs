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
	public static class LongSeqHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(LongSeqHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(CORBA.LongSeqHelper.Id(), "LongSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 3)));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, int[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static int[] Extract(CORBA.Any any)
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
			return "IDL:CORBA/LongSeq:1.0";
		}

		public static int[] Read(CORBA.IInputStream inputStream)
		{
			int[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				var _array = new int[_capacity0];
				inputStream.ReadLongArray(ref _array, 0, _capacity0);
				result = _array;
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, int[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				outputStream.WriteLongArray(value, 0, value.Length);
			}
		}

	}
}
