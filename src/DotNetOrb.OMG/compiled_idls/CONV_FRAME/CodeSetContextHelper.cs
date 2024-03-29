/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CONV_FRAME
{
	public static class CodeSetContextHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(CodeSetContextHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CONV_FRAME.CodeSetContextHelper.Id(), "CodeSetContext", new CORBA.StructMember[] {new CORBA.StructMember("char_data", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), null), new CORBA.StructMember("wchar_data", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CONV_FRAME.CodeSetContext s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CONV_FRAME.CodeSetContext Extract(CORBA.Any any)
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
			return "IDL:CONV_FRAME/CodeSetContext:1.0";
		}

		public static CONV_FRAME.CodeSetContext Read(CORBA.IInputStream inputStream)
		{
			var result = new CONV_FRAME.CodeSetContext();
			result.CharData = inputStream.ReadULong();
			result.WcharData = inputStream.ReadULong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CONV_FRAME.CodeSetContext s)
		{
			outputStream.WriteULong(s.CharData);
			outputStream.WriteULong(s.WcharData);
		}

	}
}
