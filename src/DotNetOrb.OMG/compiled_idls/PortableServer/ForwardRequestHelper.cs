/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{
	public static class ForwardRequestHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(ForwardRequestHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateExceptionTc(PortableServer.ForwardRequestHelper.Id(), "ForwardRequest", new CORBA.StructMember[] {new CORBA.StructMember("forward_reference", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 14), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, PortableServer.ForwardRequest e)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), e);
		}

		public static PortableServer.ForwardRequest Extract(CORBA.Any any)
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
			return "IDL:PortableServer/ForwardRequest:1.0";
		}

		public static PortableServer.ForwardRequest Read(CORBA.IInputStream inputStream)
		{
			var id = inputStream.ReadString();
			if (!id.Equals(Id()))
			{
				throw new CORBA.Marshal("Wrong id: " + id);
			}
			var result = new PortableServer.ForwardRequest();
			result.ForwardReference = inputStream.ReadObject();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, PortableServer.ForwardRequest e)
		{
			outputStream.WriteString(Id());
			outputStream.WriteObject(e.ForwardReference);
		}

	}
}
