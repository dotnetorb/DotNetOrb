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
	public static class LocateRequestHeader11Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(LocateRequestHeader11Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(GIOP.LocateRequestHeader11Helper.Id(), "LocateRequestHeader_1_1", GIOP.LocateRequestHeader10Helper.Type());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.LocateRequestHeader10 value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.LocateRequestHeader10 Extract(CORBA.Any any)
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
			return "IDL:GIOP/LocateRequestHeader_1_1:1.0";
		}

		public static GIOP.LocateRequestHeader10 Read(CORBA.IInputStream inputStream)
		{
			GIOP.LocateRequestHeader10 result;
			result = GIOP.LocateRequestHeader10Helper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.LocateRequestHeader10 value)
		{
			GIOP.LocateRequestHeader10Helper.Write(outputStream, value);
		}

	}
}
