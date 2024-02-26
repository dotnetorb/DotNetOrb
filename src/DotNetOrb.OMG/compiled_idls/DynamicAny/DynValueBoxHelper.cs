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
		public static class DynValueBoxHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(DynValueBoxHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:DynamicAny/DynValueBox:1.0", "DynValueBox");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, DynamicAny.IDynValueBox ifz)
			{
				any.InsertObject(ifz);
			}

			public static DynamicAny.IDynValueBox Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:DynamicAny/DynValueBox:1.0";
			}

			public static DynamicAny.IDynValueBox Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, DynamicAny.IDynValueBox ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static DynamicAny.IDynValueBox Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DynamicAny.IDynValueBox)
				{
					return (DynamicAny.IDynValueBox)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static DynamicAny.IDynValueBox UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DynamicAny.IDynValueBox)
				{
					return (DynamicAny.IDynValueBox)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
