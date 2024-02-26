/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{
		public static class GenericFactoryHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(GenericFactoryHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:omg.org/PortableGroup/GenericFactory:1.0", "GenericFactory");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, PortableGroup.IGenericFactory ifz)
			{
				any.InsertObject(ifz);
			}

			public static PortableGroup.IGenericFactory Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:omg.org/PortableGroup/GenericFactory:1.0";
			}

			public static PortableGroup.IGenericFactory Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_GenericFactoryStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, PortableGroup.IGenericFactory ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static PortableGroup.IGenericFactory Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableGroup.IGenericFactory)
				{
					return (PortableGroup.IGenericFactory)obj;
				}
				else if (obj._IsA("IDL:omg.org/PortableGroup/GenericFactory:1.0"))
				{
					_GenericFactoryStub stub = new _GenericFactoryStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static PortableGroup.IGenericFactory UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is PortableGroup.IGenericFactory)
				{
					return (PortableGroup.IGenericFactory)obj;
				}
				else
				{
					_GenericFactoryStub stub = new _GenericFactoryStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
