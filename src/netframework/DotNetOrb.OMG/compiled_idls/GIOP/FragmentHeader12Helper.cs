/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace GIOP
{
	public static class FragmentHeader12Helper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(FragmentHeader12Helper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(GIOP.FragmentHeader12Helper.Id(), "FragmentHeader_1_2", new CORBA.StructMember[] {new CORBA.StructMember("request_id", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.FragmentHeader12 s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static GIOP.FragmentHeader12 Extract(CORBA.Any any)
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
			return "IDL:GIOP/FragmentHeader_1_2:1.0";
		}

		public static GIOP.FragmentHeader12 Read(CORBA.IInputStream inputStream)
		{
			var result = new GIOP.FragmentHeader12();
			result.RequestId = inputStream.ReadULong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.FragmentHeader12 s)
		{
			outputStream.WriteULong(s.RequestId);
		}

	}
}
