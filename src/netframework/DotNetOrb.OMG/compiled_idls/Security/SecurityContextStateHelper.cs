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
	public static class SecurityContextStateHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(SecurityContextStateHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(Security.SecurityContextStateHelper.Id(),"SecurityContextState", new String[] {"SecContextInitialized", "SecContextContinued", "SecContextClientEstablished", "SecContextEstablished", "SecContextEstablishExpired", "SecContextExpired", "SecContextInvalid"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, Security.SecurityContextState value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static Security.SecurityContextState Extract(CORBA.Any any)
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
			return "IDL:omg.org/Security/SecurityContextState:1.0";
		}

		public static Security.SecurityContextState Read(CORBA.IInputStream inputStream)
		{
			return (Security.SecurityContextState) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, Security.SecurityContextState value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}