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
	public static class DIIPollableHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(DIIPollableHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateValueTc(CORBA.DIIPollableHelper.Id(), "DIIPollable", 0, null, new CORBA.ValueMember[] {});
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.IDIIPollable value)
		{
			any.InsertValue(value);
		}

		public static CORBA.IDIIPollable Extract(CORBA.Any any)
		{
			try
			{
				return (CORBA.IDIIPollable) any.ExtractValue();
			}
			catch (InvalidCastException ex)
			{
				throw new CORBA.Marshal(ex.Message);
			}
		}

		public static string Id()
		{
			return "IDL:CORBA/DIIPollable:1.0";
		}

		public static CORBA.IDIIPollable Read(CORBA.IInputStream inputStream)
		{
			return (CORBA.IDIIPollable) inputStream.ReadValue("IDL:CORBA/DIIPollable:1.0");
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.IDIIPollable value)
		{
			outputStream.WriteValue(value, "IDL:CORBA/DIIPollable:1.0");
		}

	}
}