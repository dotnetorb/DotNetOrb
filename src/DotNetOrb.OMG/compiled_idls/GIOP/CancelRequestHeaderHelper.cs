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
	public static class CancelRequestHeaderHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(CancelRequestHeaderHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(GIOP.CancelRequestHeaderHelper.Id(), "CancelRequestHeader", new CORBA.StructMember[] {new CORBA.StructMember("request_id", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.CancelRequestHeader s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static GIOP.CancelRequestHeader Extract(CORBA.Any any)
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
			return "IDL:GIOP/CancelRequestHeader:1.0";
		}

		public static GIOP.CancelRequestHeader Read(CORBA.IInputStream inputStream)
		{
			var result = new GIOP.CancelRequestHeader();
			result.RequestId = inputStream.ReadULong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.CancelRequestHeader s)
		{
			outputStream.WriteULong(s.RequestId);
		}

	}
}