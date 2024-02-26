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
	public static class PortNumberHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(PortNumberHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(DotNetOrb.ImR.PortNumberHelper.Id(), "PortNumber", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, uint value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static uint Extract(CORBA.Any any)
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
			return "IDL:DotNetOrb/ImR/PortNumber:1.0";
		}

		public static uint Read(CORBA.IInputStream inputStream)
		{
			uint result;
			result = inputStream.ReadULong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, uint value)
		{
			outputStream.WriteULong(value);
		}

	}
}