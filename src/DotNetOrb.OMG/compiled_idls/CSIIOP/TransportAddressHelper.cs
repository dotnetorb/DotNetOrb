/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CSIIOP
{
	public static class TransportAddressHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(TransportAddressHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CSIIOP.TransportAddressHelper.Id(), "TransportAddress", new CORBA.StructMember[] {new CORBA.StructMember("host_name", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("port", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 2), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CSIIOP.TransportAddress s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CSIIOP.TransportAddress Extract(CORBA.Any any)
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
			return "IDL:CSIIOP/TransportAddress:1.0";
		}

		public static CSIIOP.TransportAddress Read(CORBA.IInputStream inputStream)
		{
			var result = new CSIIOP.TransportAddress();
			result.HostName = inputStream.ReadString();
			result.Port = inputStream.ReadUShort();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CSIIOP.TransportAddress s)
		{
			outputStream.WriteString(s.HostName);
			outputStream.WriteUShort(s.Port);
		}

	}
}
