/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:27
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
		public static class OperationDefHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(OperationDefHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:CORBA/OperationDef:1.0", "OperationDef");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CORBA.IOperationDef ifz)
			{
				any.InsertObject(ifz);
			}

			public static CORBA.IOperationDef Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:CORBA/OperationDef:1.0";
			}

			public static CORBA.IOperationDef Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_OperationDefStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, CORBA.IOperationDef ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static CORBA.IOperationDef Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IOperationDef)
				{
					return (CORBA.IOperationDef)obj;
				}
				else if (obj._IsA("IDL:CORBA/OperationDef:1.0"))
				{
					_OperationDefStub stub = new _OperationDefStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static CORBA.IOperationDef UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IOperationDef)
				{
					return (CORBA.IOperationDef)obj;
				}
				else
				{
					_OperationDefStub stub = new _OperationDefStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
