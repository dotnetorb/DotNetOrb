/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace ImplementationRepository
{
		public static class AdministrationHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(AdministrationHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:ImplementationRepository/Administration:1.0", "Administration");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, ImplementationRepository.IAdministration ifz)
			{
				any.InsertObject(ifz);
			}

			public static ImplementationRepository.IAdministration Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:ImplementationRepository/Administration:1.0";
			}

			public static ImplementationRepository.IAdministration Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_AdministrationStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, ImplementationRepository.IAdministration ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static ImplementationRepository.IAdministration Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is ImplementationRepository.IAdministration)
				{
					return (ImplementationRepository.IAdministration)obj;
				}
				else if (obj._IsA("IDL:ImplementationRepository/Administration:1.0"))
				{
					_AdministrationStub stub = new _AdministrationStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static ImplementationRepository.IAdministration UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is ImplementationRepository.IAdministration)
				{
					return (ImplementationRepository.IAdministration)obj;
				}
				else
				{
					_AdministrationStub stub = new _AdministrationStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}
