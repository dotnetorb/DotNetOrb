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
	public static class ReplyStatusTypeHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ReplyStatusTypeHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(GIOP.ReplyStatusTypeHelper.Id(), "ReplyStatusType", GIOP.ReplyStatusType12Helper.Type());
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
			return "IDL:GIOP/ReplyStatusType:1.0";
		}

		public static GIOP.ReplyStatusType12 Read(CORBA.IInputStream inputStream)
		{
			GIOP.ReplyStatusType12 result;
			result = GIOP.ReplyStatusType12Helper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.ReplyStatusType12 value)
		{
			GIOP.ReplyStatusType12Helper.Write(outputStream, value);
		}

	}
}
