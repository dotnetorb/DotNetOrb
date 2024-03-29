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
	public static class AttributeModeHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(AttributeModeHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(CORBA.AttributeModeHelper.Id(),"AttributeMode", new String[] {"ATTR_NORMAL", "ATTR_READONLY"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.AttributeMode value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static CORBA.AttributeMode Extract(CORBA.Any any)
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
			return "IDL:CORBA/AttributeMode:1.0";
		}

		public static CORBA.AttributeMode Read(CORBA.IInputStream inputStream)
		{
			return (CORBA.AttributeMode) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.AttributeMode value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}
