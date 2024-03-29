/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CosNaming
{
		public static class NamingContextExtHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(NamingContextExtHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:omg.org/CosNaming/NamingContextExt:1.0", "NamingContextExt");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CosNaming.INamingContextExt ifz)
			{
				any.InsertObject(ifz);
			}

			public static CosNaming.INamingContextExt Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:omg.org/CosNaming/NamingContextExt:1.0";
			}

			public static CosNaming.INamingContextExt Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_NamingContextExtStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, CosNaming.INamingContextExt ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static CosNaming.INamingContextExt Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CosNaming.INamingContextExt)
				{
					return (CosNaming.INamingContextExt)obj;
				}
				else if (obj._IsA("IDL:omg.org/CosNaming/NamingContextExt:1.0"))
				{
					_NamingContextExtStub stub = new _NamingContextExtStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static CosNaming.INamingContextExt UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CosNaming.INamingContextExt)
				{
					return (CosNaming.INamingContextExt)obj;
				}
				else
				{
					_NamingContextExtStub stub = new _NamingContextExtStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
