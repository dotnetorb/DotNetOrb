/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DotNetOrb.SSL
{
	public static class SSLPolicyValueHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(SSLPolicyValueHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateEnumTc(DotNetOrb.SSL.SSLPolicyValueHelper.Id(),"SSLPolicyValue", new String[] {"SSL_NOT_REQUIRED", "SSL_REQUIRED"});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, DotNetOrb.SSL.SSLPolicyValue value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static DotNetOrb.SSL.SSLPolicyValue Extract(CORBA.Any any)
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
			return "IDL:DotNetOrb/SSL/SSLPolicyValue:1.0";
		}

		public static DotNetOrb.SSL.SSLPolicyValue Read(CORBA.IInputStream inputStream)
		{
			return (DotNetOrb.SSL.SSLPolicyValue) inputStream.ReadLong();
		}

		public static void Write(CORBA.IOutputStream outputStream, DotNetOrb.SSL.SSLPolicyValue value)
		{
			outputStream.WriteLong((int) value);
		}

	}
}