/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Compression
{
		public static class CompressorFactoryHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(CompressorFactoryHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateLocalInterfaceTc("IDL:omg.org/Compression/CompressorFactory:1.0", "CompressorFactory");
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, Compression.ICompressorFactory ifz)
			{
				any.InsertObject(ifz);
			}

			public static Compression.ICompressorFactory Extract(CORBA.Any any)
			{
				return Narrow(any.ExtractObject());
			}

			public static string Id()
			{
				return "IDL:omg.org/Compression/CompressorFactory:1.0";
			}

			public static Compression.ICompressorFactory Read(CORBA.IInputStream inputStream)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static void Write(CORBA.IOutputStream outputStream, Compression.ICompressorFactory ifz)
			{
				throw new CORBA.Marshal("Local interface");
			}

			public static Compression.ICompressorFactory Narrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is Compression.ICompressorFactory)
				{
					return (Compression.ICompressorFactory)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}

			public static Compression.ICompressorFactory UncheckedNarrow(CORBA.IObject obj)
			{
				if (obj == null)
				{
					return null;
				}
				else if (obj is Compression.ICompressorFactory)
				{
					return (Compression.ICompressorFactory)obj;
				}
				else
				{
					throw new CORBA.BadParam("Narrow failed");
				}
			}
		}
}