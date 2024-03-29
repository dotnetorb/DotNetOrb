/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
		public static class ExtAttributeDefHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ExtAttributeDefHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:CORBA/ExtAttributeDef:1.0", "ExtAttributeDef");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CORBA.IExtAttributeDef ifz)
			{
				any.InsertObject(ifz);
			}

			public static CORBA.IExtAttributeDef Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:CORBA/ExtAttributeDef:1.0";
			}

			public static CORBA.IExtAttributeDef Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_ExtAttributeDefStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, CORBA.IExtAttributeDef ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static CORBA.IExtAttributeDef Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IExtAttributeDef)
				{
					return (CORBA.IExtAttributeDef)obj;
				}
				else if (obj._IsA("IDL:CORBA/ExtAttributeDef:1.0"))
				{
					_ExtAttributeDefStub stub = new _ExtAttributeDefStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static CORBA.IExtAttributeDef UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IExtAttributeDef)
				{
					return (CORBA.IExtAttributeDef)obj;
				}
				else
				{
					_ExtAttributeDefStub stub = new _ExtAttributeDefStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
