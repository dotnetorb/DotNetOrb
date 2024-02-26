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
		public static class IRObjectHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(IRObjectHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:CORBA/IRObject:1.0", "IRObject");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CORBA.IIRObject ifz)
			{
				any.InsertObject(ifz);
			}

			public static CORBA.IIRObject Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:CORBA/IRObject:1.0";
			}

			public static CORBA.IIRObject Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_IRObjectStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, CORBA.IIRObject ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static CORBA.IIRObject Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IIRObject)
				{
					return (CORBA.IIRObject)obj;
				}
				else if (obj._IsA("IDL:CORBA/IRObject:1.0"))
				{
					_IRObjectStub stub = new _IRObjectStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static CORBA.IIRObject UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IIRObject)
				{
					return (CORBA.IIRObject)obj;
				}
				else
				{
					_IRObjectStub stub = new _IRObjectStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
