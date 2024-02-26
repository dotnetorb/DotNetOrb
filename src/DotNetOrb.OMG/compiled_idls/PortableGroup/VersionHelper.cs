/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{
	public static class VersionHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(VersionHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(PortableGroup.VersionHelper.Id(), "Version", GIOP.VersionHelper.Type());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.Version value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.Version Extract(CORBA.Any any)
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
			return "IDL:omg.org/PortableGroup/Version:1.0";
		}

		public static GIOP.Version Read(CORBA.IInputStream inputStream)
		{
			GIOP.Version result;
			result = GIOP.VersionHelper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.Version value)
		{
			GIOP.VersionHelper.Write(outputStream, value);
		}

	}
}
