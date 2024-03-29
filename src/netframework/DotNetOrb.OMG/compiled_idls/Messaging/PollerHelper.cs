/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:35
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Messaging
{
	public static class PollerHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(PollerHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateValueTc(Messaging.PollerHelper.Id(), "Poller", 0, null, new CORBA.ValueMember[] {});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, Messaging.IPoller value)
		{
			any.InsertValue(value);
		}

		public static Messaging.IPoller Extract(CORBA.Any any)
		{
			try
			{
				return (Messaging.IPoller) any.ExtractValue();
			}
			catch (InvalidCastException ex)
			{
				throw new CORBA.Marshal(ex.Message);
			}
		}

		public static string Id()
		{
			return "IDL:omg.org/Messaging/Poller:3.1";
		}

		public static Messaging.IPoller Read(CORBA.IInputStream inputStream)
		{
			return (Messaging.IPoller) inputStream.ReadValue("IDL:omg.org/Messaging/Poller:3.1");
		}

		public static void Write(CORBA.IOutputStream outputStream, Messaging.IPoller value)
		{
			outputStream.WriteValue(value, "IDL:omg.org/Messaging/Poller:3.1");
		}

	}
}
