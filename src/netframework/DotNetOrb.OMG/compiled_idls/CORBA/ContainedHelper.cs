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
		public static class ContainedHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ContainedHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:CORBA/Contained:1.0", "Contained");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CORBA.IContained ifz)
			{
				any.InsertObject(ifz);
			}

			public static CORBA.IContained Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:CORBA/Contained:1.0";
			}

			public static CORBA.IContained Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_ContainedStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, CORBA.IContained ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static CORBA.IContained Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IContained)
				{
					return (CORBA.IContained)obj;
				}
				else if (obj._IsA("IDL:CORBA/Contained:1.0"))
				{
					_ContainedStub stub = new _ContainedStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static CORBA.IContained UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is CORBA.IContained)
				{
					return (CORBA.IContained)obj;
				}
				else
				{
					_ContainedStub stub = new _ContainedStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
