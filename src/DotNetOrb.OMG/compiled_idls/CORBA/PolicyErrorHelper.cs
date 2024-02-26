/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public static class PolicyErrorHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(PolicyErrorHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateExceptionTc(CORBA.PolicyErrorHelper.Id(), "PolicyError", new CORBA.StructMember[] {new CORBA.StructMember("reason", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 4), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.PolicyError e)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), e);
		}

		public static CORBA.PolicyError Extract(CORBA.Any any)
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
			return "IDL:CORBA/PolicyError:1.0";
		}

		public static CORBA.PolicyError Read(CORBA.IInputStream inputStream)
		{
			var id = inputStream.ReadString();
			if (!id.Equals(Id()))
			{
				throw new CORBA.Marshal("Wrong id: " + id);
			}
			var result = new CORBA.PolicyError();
			result.Reason = inputStream.ReadShort();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.PolicyError e)
		{
			outputStream.WriteString(Id());
			outputStream.WriteShort(e.Reason);
		}

	}
}