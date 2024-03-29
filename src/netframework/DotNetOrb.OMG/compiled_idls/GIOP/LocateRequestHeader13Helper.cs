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
	public static class LocateRequestHeader13Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(LocateRequestHeader13Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(GIOP.LocateRequestHeader13Helper.Id(), "LocateRequestHeader_1_3", GIOP.LocateRequestHeader12Helper.Type());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.LocateRequestHeader12 value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.LocateRequestHeader12 Extract(CORBA.Any any)
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
			return "IDL:GIOP/LocateRequestHeader_1_3:1.0";
		}

		public static GIOP.LocateRequestHeader12 Read(CORBA.IInputStream inputStream)
		{
			GIOP.LocateRequestHeader12 result;
			result = GIOP.LocateRequestHeader12Helper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.LocateRequestHeader12 value)
		{
			GIOP.LocateRequestHeader12Helper.Write(outputStream, value);
		}

	}
}
