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
	public static class ReplyStatusType12Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ReplyStatusType12Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(GIOP.ReplyStatusType12Helper.Id(),"ReplyStatusType_1_2", new String[] {"NO_EXCEPTION", "USER_EXCEPTION", "SYSTEM_EXCEPTION", "LOCATION_FORWARD", "LOCATION_FORWARD_PERM", "NEEDS_ADDRESSING_MODE"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.ReplyStatusType12 value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.ReplyStatusType12 Extract(CORBA.Any any)
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
			return "IDL:GIOP/ReplyStatusType_1_2:1.0";
		}

		public static GIOP.ReplyStatusType12 Read(CORBA.IInputStream inputStream)
		{
			return (GIOP.ReplyStatusType12) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.ReplyStatusType12 value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}
