/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace RTCORBA
{
	public static class ThreadpoolLanesHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ThreadpoolLanesHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(RTCORBA.ThreadpoolLanesHelper.Id(), "ThreadpoolLanes", CORBA.ORB.Init().CreateSequenceTc(0, RTCORBA.ThreadpoolLaneHelper.Type()));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, RTCORBA.ThreadpoolLane[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static RTCORBA.ThreadpoolLane[] Extract(CORBA.Any any)
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
			return "IDL:RTCORBA/ThreadpoolLanes:1.0";
		}

		public static RTCORBA.ThreadpoolLane[] Read(CORBA.IInputStream inputStream)
		{
			RTCORBA.ThreadpoolLane[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result = new RTCORBA.ThreadpoolLane[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					RTCORBA.ThreadpoolLane _item0;
					_item0 = RTCORBA.ThreadpoolLaneHelper.Read(inputStream);
					result[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, RTCORBA.ThreadpoolLane[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				for (int i0 = 0; i0 < value.Length; i0++)
				{
					RTCORBA.ThreadpoolLaneHelper.Write(outputStream, value[i0]);
				}
			}
		}

	}
}
