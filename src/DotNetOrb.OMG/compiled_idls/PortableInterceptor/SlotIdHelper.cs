/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableInterceptor
{
	public static class SlotIdHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(SlotIdHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(PortableInterceptor.SlotIdHelper.Id(), "SlotId", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, uint value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static uint Extract(CORBA.Any any)
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
			return "IDL:PortableInterceptor/SlotId:1.0";
		}

		public static uint Read(CORBA.IInputStream inputStream)
		{
			uint result;
			result = inputStream.ReadULong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, uint value)
		{
			outputStream.WriteULong(value);
		}

	}
}
