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
		public static class DynAnyHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(DynAnyHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:DynamicAny/DynAny:1.0", "DynAny");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, DynamicAny.IDynAny ifz)
			{
				any.InsertObject(ifz);
			}

			public static DynamicAny.IDynAny Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:DynamicAny/DynAny:1.0";
			}

			public static DynamicAny.IDynAny Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, DynamicAny.IDynAny ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static DynamicAny.IDynAny Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DynamicAny.IDynAny)
				{
					return (DynamicAny.IDynAny)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static DynamicAny.IDynAny UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DynamicAny.IDynAny)
				{
					return (DynamicAny.IDynAny)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
