/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DotNetOrb.ImR
{
	public static class HostNameHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(HostNameHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(DotNetOrb.ImR.HostNameHelper.Id(), "HostName", CORBA.ORB.Init().CreateStringTc(0));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, string value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static string Extract(CORBA.Any any)
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
			return "IDL:DotNetOrb/ImR/HostName:1.0";
		}

		public static string Read(CORBA.IInputStream inputStream)
		{
			string result;
			result = inputStream.ReadString();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, string value)
		{
			outputStream.WriteString(value);
		}

	}
}
