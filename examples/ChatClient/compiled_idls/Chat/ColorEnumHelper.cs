/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Chat
{
	public static class ColorEnumHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ColorEnumHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(Chat.ColorEnumHelper.Id(),"ColorEnum", new String[] {"Default", "Green", "Yellow", "Red"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, Chat.ColorEnum value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static Chat.ColorEnum Extract(CORBA.Any any)
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
			return "IDL:Chat/ColorEnum:1.0";
		}

		public static Chat.ColorEnum Read(CORBA.IInputStream inputStream)
		{
			return (Chat.ColorEnum) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, Chat.ColorEnum value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}
