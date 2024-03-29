/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Compression
{
	public static class CompressorIdHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(CompressorIdHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(Compression.CompressorIdHelper.Id(), "CompressorId", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 2));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, ushort value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static ushort Extract(CORBA.Any any)
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
			return "IDL:omg.org/Compression/CompressorId:1.0";
		}

		public static ushort Read(CORBA.IInputStream inputStream)
		{
			ushort result;
			result = inputStream.ReadUShort();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, ushort value)
		{
			outputStream.WriteUShort(value);
		}

	}
}
