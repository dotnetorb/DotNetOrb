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
	public static class ExtValueDefSeqHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ExtValueDefSeqHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(CORBA.ExtValueDefSeqHelper.Id(), "ExtValueDefSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ExtValueDefHelper.Type()));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.IExtValueDef[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static CORBA.IExtValueDef[] Extract(CORBA.Any any)
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
			return "IDL:CORBA/ExtValueDefSeq:1.0";
		}

		public static CORBA.IExtValueDef[] Read(CORBA.IInputStream inputStream)
		{
			CORBA.IExtValueDef[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result = new CORBA.IExtValueDef[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CORBA.IExtValueDef _item0;
					_item0 = CORBA.ExtValueDefHelper.Read(inputStream);
					result[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.IExtValueDef[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				for (int i0 = 0; i0 < value.Length; i0++)
				{
					CORBA.ExtValueDefHelper.Write(outputStream, value[i0]);
				}
			}
		}

	}
}
