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
	public static class CodeSetComponentInfoHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(CodeSetComponentInfoHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CONV_FRAME.CodeSetComponentInfoHelper.Id(), "CodeSetComponentInfo", new CORBA.StructMember[] {new CORBA.StructMember("ForCharData", CONV_FRAME.CodeSetComponentHelper.Type(), null), new CORBA.StructMember("ForWcharData", CONV_FRAME.CodeSetComponentHelper.Type(), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CONV_FRAME.CodeSetComponentInfo s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CONV_FRAME.CodeSetComponentInfo Extract(CORBA.Any any)
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
			return "IDL:CONV_FRAME/CodeSetComponentInfo:1.0";
		}

		public static CONV_FRAME.CodeSetComponentInfo Read(CORBA.IInputStream inputStream)
		{
			var result = new CONV_FRAME.CodeSetComponentInfo();
			result.ForCharData = CONV_FRAME.CodeSetComponentHelper.Read(inputStream);
			result.ForWcharData = CONV_FRAME.CodeSetComponentHelper.Read(inputStream);
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CONV_FRAME.CodeSetComponentInfo s)
		{
			CONV_FRAME.CodeSetComponentHelper.Write(outputStream, s.ForCharData);
			CONV_FRAME.CodeSetComponentHelper.Write(outputStream, s.ForWcharData);
		}

	}
}
