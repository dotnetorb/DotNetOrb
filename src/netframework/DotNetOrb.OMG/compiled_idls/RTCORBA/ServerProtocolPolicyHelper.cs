/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace RTCORBA
{
		public static class ServerProtocolPolicyHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ServerProtocolPolicyHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:RTCORBA/ServerProtocolPolicy:1.0", "ServerProtocolPolicy");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, RTCORBA.IServerProtocolPolicy ifz)
			{
				any.InsertObject(ifz);
			}

			public static RTCORBA.IServerProtocolPolicy Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:RTCORBA/ServerProtocolPolicy:1.0";
			}

			public static RTCORBA.IServerProtocolPolicy Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, RTCORBA.IServerProtocolPolicy ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static RTCORBA.IServerProtocolPolicy Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is RTCORBA.IServerProtocolPolicy)
				{
					return (RTCORBA.IServerProtocolPolicy)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static RTCORBA.IServerProtocolPolicy UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is RTCORBA.IServerProtocolPolicy)
				{
					return (RTCORBA.IServerProtocolPolicy)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
