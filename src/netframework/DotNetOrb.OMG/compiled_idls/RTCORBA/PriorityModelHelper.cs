/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace RTCORBA
{
	public static class PriorityModelHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(PriorityModelHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(RTCORBA.PriorityModelHelper.Id(),"PriorityModel", new String[] {"CLIENT_PROPAGATED", "SERVER_DECLARED"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, RTCORBA.PriorityModel value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static RTCORBA.PriorityModel Extract(CORBA.Any any)
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
			return "IDL:RTCORBA/PriorityModel:1.0";
		}

		public static RTCORBA.PriorityModel Read(CORBA.IInputStream inputStream)
		{
			return (RTCORBA.PriorityModel) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, RTCORBA.PriorityModel value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}
