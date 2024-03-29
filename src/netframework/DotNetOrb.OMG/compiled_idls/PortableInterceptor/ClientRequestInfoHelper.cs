/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableInterceptor
{
		public static class ClientRequestInfoHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ClientRequestInfoHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:PortableInterceptor/ClientRequestInfo:1.0", "ClientRequestInfo");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, PortableInterceptor.IClientRequestInfo ifz)
			{
				any.InsertObject(ifz);
			}

			public static PortableInterceptor.IClientRequestInfo Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:PortableInterceptor/ClientRequestInfo:1.0";
			}

			public static PortableInterceptor.IClientRequestInfo Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, PortableInterceptor.IClientRequestInfo ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static PortableInterceptor.IClientRequestInfo Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableInterceptor.IClientRequestInfo)
				{
					return (PortableInterceptor.IClientRequestInfo)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static PortableInterceptor.IClientRequestInfo UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableInterceptor.IClientRequestInfo)
				{
					return (PortableInterceptor.IClientRequestInfo)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
