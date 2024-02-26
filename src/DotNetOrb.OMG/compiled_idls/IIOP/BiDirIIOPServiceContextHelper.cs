/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace IIOP
{
	public static class BiDirIIOPServiceContextHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(BiDirIIOPServiceContextHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(IIOP.BiDirIIOPServiceContextHelper.Id(), "BiDirIIOPServiceContext", new CORBA.StructMember[] {new CORBA.StructMember("listen_points", CORBA.ORB.Init().CreateSequenceTc(0, IIOP.ListenPointHelper.Type()), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, IIOP.BiDirIIOPServiceContext s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static IIOP.BiDirIIOPServiceContext Extract(CORBA.Any any)
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
			return "IDL:IIOP/BiDirIIOPServiceContext:1.0";
		}

		public static IIOP.BiDirIIOPServiceContext Read(CORBA.IInputStream inputStream)
		{
			var result = new IIOP.BiDirIIOPServiceContext();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.ListenPoints = new IIOP.ListenPoint[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					IIOP.ListenPoint _item0;
					_item0 = IIOP.ListenPointHelper.Read(inputStream);
					result.ListenPoints[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, IIOP.BiDirIIOPServiceContext s)
		{
			{
				outputStream.WriteLong(s.ListenPoints.Length);
				for (int i0 = 0; i0 < s.ListenPoints.Length; i0++)
				{
					IIOP.ListenPointHelper.Write(outputStream, s.ListenPoints[i0]);
				}
			}
		}

	}
}