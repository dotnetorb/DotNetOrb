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
	public static class ObjectGroupIdHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ObjectGroupIdHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(PortableGroup.ObjectGroupIdHelper.Id(), "ObjectGroupId", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 24));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, ulong value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static ulong Extract(CORBA.Any any)
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
			return "IDL:omg.org/PortableGroup/ObjectGroupId:1.0";
		}

		public static ulong Read(CORBA.IInputStream inputStream)
		{
			ulong result;
			result = inputStream.ReadULongLong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, ulong value)
		{
			outputStream.WriteULongLong(value);
		}

	}
}
