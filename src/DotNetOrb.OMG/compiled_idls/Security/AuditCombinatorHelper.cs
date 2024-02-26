/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Security
{
	public static class AuditCombinatorHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(AuditCombinatorHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(Security.AuditCombinatorHelper.Id(),"AuditCombinator", new String[] {"SecAllSelectors", "SecAnySelector"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, Security.AuditCombinator value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static Security.AuditCombinator Extract(CORBA.Any any)
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
			return "IDL:omg.org/Security/AuditCombinator:1.0";
		}

		public static Security.AuditCombinator Read(CORBA.IInputStream inputStream)
		{
			return (Security.AuditCombinator) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, Security.AuditCombinator value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}
