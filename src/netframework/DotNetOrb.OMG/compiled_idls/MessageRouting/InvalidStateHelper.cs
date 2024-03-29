/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:36
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace MessageRouting
{
	public static class InvalidStateHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(InvalidStateHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateExceptionTc(MessageRouting.InvalidStateHelper.Id(), "InvalidState", new CORBA.StructMember[] {new CORBA.StructMember("registration_state", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 4), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, MessageRouting.InvalidState e)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), e);
		}

		public static MessageRouting.InvalidState Extract(CORBA.Any any)
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
			return "IDL:MessageRouting/InvalidState:1.0";
		}

		public static MessageRouting.InvalidState Read(CORBA.IInputStream inputStream)
		{
			var id = inputStream.ReadString();
			if (!id.Equals(Id()))
			{
				throw new CORBA.Marshal("Wrong id: " + id);
			}
			var result = new MessageRouting.InvalidState();
			result.RegistrationState = inputStream.ReadShort();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, MessageRouting.InvalidState e)
		{
			outputStream.WriteString(Id());
			outputStream.WriteShort(e.RegistrationState);
		}

	}
}
