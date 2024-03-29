/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace ETF
{
		public static class ConnectionHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ConnectionHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:omg.org/ETF/Connection:1.0", "Connection");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, ETF.IConnection ifz)
			{
				any.InsertObject(ifz);
			}

			public static ETF.IConnection Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:omg.org/ETF/Connection:1.0";
			}

			public static ETF.IConnection Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, ETF.IConnection ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static ETF.IConnection Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is ETF.IConnection)
				{
					return (ETF.IConnection)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static ETF.IConnection UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is ETF.IConnection)
				{
					return (ETF.IConnection)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
