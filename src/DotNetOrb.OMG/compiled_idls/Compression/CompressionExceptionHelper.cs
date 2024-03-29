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
	public static class CompressionExceptionHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(CompressionExceptionHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateExceptionTc(Compression.CompressionExceptionHelper.Id(), "CompressionException", new CORBA.StructMember[] {new CORBA.StructMember("reason", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 3), null), new CORBA.StructMember("description", CORBA.ORB.Init().CreateStringTc(0), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, Compression.CompressionException e)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), e);
		}

		public static Compression.CompressionException Extract(CORBA.Any any)
		{
			var inputStream = any.CreateInputStream();
			try
			{
				return Read(inputStream);
			}
			finally
			{
				inputStream.Close();
			}
		}

		public static string Id()
		{
			return "IDL:omg.org/Compression/CompressionException:1.0";
		}

		public static Compression.CompressionException Read(CORBA.IInputStream inputStream)
		{
			var id = inputStream.ReadString();
			if (!id.Equals(Id()))
			{
				throw new CORBA.Marshal("Wrong id: " + id);
			}
			var result = new Compression.CompressionException();
			result.Reason = inputStream.ReadLong();
			result.Description = inputStream.ReadString();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, Compression.CompressionException e)
		{
			outputStream.WriteString(Id());
			outputStream.WriteLong(e.Reason);
			outputStream.WriteString(e.Description);
		}

	}
}
