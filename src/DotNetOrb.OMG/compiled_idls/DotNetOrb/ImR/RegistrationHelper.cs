/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DotNetOrb.ImR
{
		public static class RegistrationHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(RegistrationHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:DotNetOrb/ImR/Registration:1.0", "Registration");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, DotNetOrb.ImR.IRegistration ifz)
			{
				any.InsertObject(ifz);
			}

			public static DotNetOrb.ImR.IRegistration Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:DotNetOrb/ImR/Registration:1.0";
			}

			public static DotNetOrb.ImR.IRegistration Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_RegistrationStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, DotNetOrb.ImR.IRegistration ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static DotNetOrb.ImR.IRegistration Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DotNetOrb.ImR.IRegistration)
				{
					return (DotNetOrb.ImR.IRegistration)obj;
				}
				else if (obj._IsA("IDL:DotNetOrb/ImR/Registration:1.0"))
				{
					_RegistrationStub stub = new _RegistrationStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static DotNetOrb.ImR.IRegistration UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DotNetOrb.ImR.IRegistration)
				{
					return (DotNetOrb.ImR.IRegistration)obj;
				}
				else
				{
					_RegistrationStub stub = new _RegistrationStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
