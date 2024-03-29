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
		public static class ConstantDefHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ConstantDefHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:CORBA/ConstantDef:1.0", "ConstantDef");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CORBA.IConstantDef ifz)
			{
				any.InsertObject(ifz);
			}

			public static CORBA.IConstantDef Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:CORBA/ConstantDef:1.0";
			}

			public static CORBA.IConstantDef Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_ConstantDefStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, CORBA.IConstantDef ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static CORBA.IConstantDef Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IConstantDef)
				{
					return (CORBA.IConstantDef)obj;
				}
				else if (obj._IsA("IDL:CORBA/ConstantDef:1.0"))
				{
					_ConstantDefStub stub = new _ConstantDefStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static CORBA.IConstantDef UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IConstantDef)
				{
					return (CORBA.IConstantDef)obj;
				}
				else
				{
					_ConstantDefStub stub = new _ConstantDefStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
