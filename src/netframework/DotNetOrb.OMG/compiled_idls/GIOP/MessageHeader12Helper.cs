/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace GIOP
{
	public static class MessageHeader12Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(MessageHeader12Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(GIOP.MessageHeader12Helper.Id(), "MessageHeader_1_2", GIOP.MessageHeader11Helper.Type());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.MessageHeader11 value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.MessageHeader11 Extract(CORBA.Any any)
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
			return "IDL:GIOP/MessageHeader_1_2:1.0";
		}

		public static GIOP.MessageHeader11 Read(CORBA.IInputStream inputStream)
		{
			GIOP.MessageHeader11 result;
			result = GIOP.MessageHeader11Helper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.MessageHeader11 value)
		{
			GIOP.MessageHeader11Helper.Write(outputStream, value);
		}

	}
}
