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
	public static class MsgTypeHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(MsgTypeHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(GIOP.MsgTypeHelper.Id(), "MsgType", GIOP.MsgType11Helper.Type());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.MsgType11 value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.MsgType11 Extract(CORBA.Any any)
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
			return "IDL:GIOP/MsgType:1.0";
		}

		public static GIOP.MsgType11 Read(CORBA.IInputStream inputStream)
		{
			GIOP.MsgType11 result;
			result = GIOP.MsgType11Helper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.MsgType11 value)
		{
			GIOP.MsgType11Helper.Write(outputStream, value);
		}

	}
}
