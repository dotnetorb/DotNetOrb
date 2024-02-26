/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DotNetOrb.SSL
{
		public static class SSLPolicyHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(SSLPolicyHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:DotNetOrb/SSL/SSLPolicy:1.0", "SSLPolicy");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, DotNetOrb.SSL.ISSLPolicy ifz)
			{
				any.InsertObject(ifz);
			}

			public static DotNetOrb.SSL.ISSLPolicy Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:DotNetOrb/SSL/SSLPolicy:1.0";
			}

			public static DotNetOrb.SSL.ISSLPolicy Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, DotNetOrb.SSL.ISSLPolicy ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static DotNetOrb.SSL.ISSLPolicy Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DotNetOrb.SSL.ISSLPolicy)
				{
					return (DotNetOrb.SSL.ISSLPolicy)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static DotNetOrb.SSL.ISSLPolicy UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is DotNetOrb.SSL.ISSLPolicy)
				{
					return (DotNetOrb.SSL.ISSLPolicy)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}
