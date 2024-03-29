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
	public static class ExceptionDescriptionHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ExceptionDescriptionHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CORBA.ExceptionDescriptionHelper.Id(), "ExceptionDescription", new CORBA.StructMember[] {new CORBA.StructMember("name", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("id", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("defined_in", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("version", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("type", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 12), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CORBA.ExceptionDescription s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CORBA.ExceptionDescription Extract(CORBA.Any any)
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
			return "IDL:CORBA/ExceptionDescription:1.0";
		}

		public static CORBA.ExceptionDescription Read(CORBA.IInputStream inputStream)
		{
			var result = new CORBA.ExceptionDescription();
			result.Name = inputStream.ReadString();
			result.Id = inputStream.ReadString();
			result.DefinedIn = inputStream.ReadString();
			result.Version = inputStream.ReadString();
			result.Type = inputStream.ReadTypeCode();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CORBA.ExceptionDescription s)
		{
			outputStream.WriteString(s.Name);
			outputStream.WriteString(s.Id);
			outputStream.WriteString(s.DefinedIn);
			outputStream.WriteString(s.Version);
			outputStream.WriteTypeCode(s.Type);
		}

	}
}
