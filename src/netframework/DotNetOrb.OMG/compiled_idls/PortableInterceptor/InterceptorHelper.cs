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
		public static class InterceptorHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(InterceptorHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:PortableInterceptor/Interceptor:1.0", "Interceptor");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, PortableInterceptor.IInterceptor ifz)
			{
				any.InsertObject(ifz);
			}

			public static PortableInterceptor.IInterceptor Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:PortableInterceptor/Interceptor:1.0";
			}

			public static PortableInterceptor.IInterceptor Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, PortableInterceptor.IInterceptor ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static PortableInterceptor.IInterceptor Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableInterceptor.IInterceptor)
				{
					return (PortableInterceptor.IInterceptor)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static PortableInterceptor.IInterceptor UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableInterceptor.IInterceptor)
				{
					return (PortableInterceptor.IInterceptor)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
