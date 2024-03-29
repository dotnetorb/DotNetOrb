/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DynamicAny
{
		public static class DynFixedHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(DynFixedHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:DynamicAny/DynFixed:1.0", "DynFixed");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, DynamicAny.IDynFixed ifz)
			{
				any.InsertObject(ifz);
			}

			public static DynamicAny.IDynFixed Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:DynamicAny/DynFixed:1.0";
			}

			public static DynamicAny.IDynFixed Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, DynamicAny.IDynFixed ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static DynamicAny.IDynFixed Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DynamicAny.IDynFixed)
				{
					return (DynamicAny.IDynFixed)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static DynamicAny.IDynFixed UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DynamicAny.IDynFixed)
				{
					return (DynamicAny.IDynFixed)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
