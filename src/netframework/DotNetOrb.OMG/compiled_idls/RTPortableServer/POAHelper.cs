/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace RTPortableServer
{
		public static class POAHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(POAHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:RTPortableServer/POA:1.0", "POA");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, RTPortableServer.IPOA ifz)
			{
				any.InsertObject(ifz);
			}

			public static RTPortableServer.IPOA Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:RTPortableServer/POA:1.0";
			}

			public static RTPortableServer.IPOA Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, RTPortableServer.IPOA ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static RTPortableServer.IPOA Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is RTPortableServer.IPOA)
				{
					return (RTPortableServer.IPOA)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static RTPortableServer.IPOA UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is RTPortableServer.IPOA)
				{
					return (RTPortableServer.IPOA)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
