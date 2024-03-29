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
		public static class ThreadPolicyHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ThreadPolicyHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:PortableServer/ThreadPolicy:1.0", "ThreadPolicy");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, PortableServer.IThreadPolicy ifz)
			{
				any.InsertObject(ifz);
			}

			public static PortableServer.IThreadPolicy Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:PortableServer/ThreadPolicy:1.0";
			}

			public static PortableServer.IThreadPolicy Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, PortableServer.IThreadPolicy ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static PortableServer.IThreadPolicy Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableServer.IThreadPolicy)
				{
					return (PortableServer.IThreadPolicy)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static PortableServer.IThreadPolicy UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableServer.IThreadPolicy)
				{
					return (PortableServer.IThreadPolicy)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
