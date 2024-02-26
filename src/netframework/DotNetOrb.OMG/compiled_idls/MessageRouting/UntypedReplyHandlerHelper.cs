/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:36
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace MessageRouting
{
		public static class UntypedReplyHandlerHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(UntypedReplyHandlerHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateInterfaceTc("IDL:MessageRouting/UntypedReplyHandler:1.0", "UntypedReplyHandler");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, MessageRouting.IUntypedReplyHandler ifz)
			{
				any.InsertObject(ifz);
			}

			public static MessageRouting.IUntypedReplyHandler Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:MessageRouting/UntypedReplyHandler:1.0";
			}

			public static MessageRouting.IUntypedReplyHandler Read(CORBA.IInputStream inputStream)
			{
				return Narrow(inputStream.ReadObject(typeof(_UntypedReplyHandlerStub)));
			}

			public static void Write(CORBA.IOutputStream outputStream, MessageRouting.IUntypedReplyHandler ifz)
			{
				outputStream.WriteObject(ifz);
			}

			public static MessageRouting.IUntypedReplyHandler Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is MessageRouting.IUntypedReplyHandler)
				{
					return (MessageRouting.IUntypedReplyHandler)obj;
				}
				else if (obj._IsA("IDL:MessageRouting/UntypedReplyHandler:1.0"))
				{
					_UntypedReplyHandlerStub stub = new _UntypedReplyHandlerStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static MessageRouting.IUntypedReplyHandler UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is MessageRouting.IUntypedReplyHandler)
				{
					return (MessageRouting.IUntypedReplyHandler)obj;
				}
				else
				{
					_UntypedReplyHandlerStub stub = new _UntypedReplyHandlerStub();
					stub._Delegate = ((CORBA.Object)obj)._Delegate;
					return stub;
				}
			}
		}
}