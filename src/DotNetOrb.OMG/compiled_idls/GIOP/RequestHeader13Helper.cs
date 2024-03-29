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
	public static class RequestHeader13Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(RequestHeader13Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(GIOP.RequestHeader13Helper.Id(), "RequestHeader_1_3", GIOP.RequestHeader12Helper.Type());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.RequestHeader12 value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.RequestHeader12 Extract(CORBA.Any any)
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
			return "IDL:GIOP/RequestHeader_1_3:1.0";
		}

		public static GIOP.RequestHeader12 Read(CORBA.IInputStream inputStream)
		{
			GIOP.RequestHeader12 result;
			result = GIOP.RequestHeader12Helper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.RequestHeader12 value)
		{
			GIOP.RequestHeader12Helper.Write(outputStream, value);
		}

	}
}
