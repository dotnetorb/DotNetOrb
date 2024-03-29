/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Test
{
		public static class RecursiveHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(RecursiveHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:Test/Recursive:1.0", "Recursive");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, Test.IRecursive ifz)
			{
				any.InsertObject(ifz);
			}

			public static Test.IRecursive Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:Test/Recursive:1.0";
			}

			public static Test.IRecursive Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_RecursiveStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, Test.IRecursive ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static Test.IRecursive Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is Test.IRecursive)
				{
					return (Test.IRecursive)obj;
				}
				else if (obj._IsA("IDL:Test/Recursive:1.0"))
				{
					_RecursiveStub stub = new _RecursiveStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static Test.IRecursive UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is Test.IRecursive)
				{
					return (Test.IRecursive)obj;
				}
				else
				{
					_RecursiveStub stub = new _RecursiveStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
