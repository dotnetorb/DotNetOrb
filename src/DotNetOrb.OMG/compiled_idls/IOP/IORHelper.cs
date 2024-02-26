/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace IOP
{
	public static class IORHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(IORHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(IOP.IORHelper.Id(), "IOR", new CORBA.StructMember[] {new CORBA.StructMember("type_id", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("profiles", CORBA.ORB.Init().CreateSequenceTc(0, IOP.TaggedProfileHelper.Type()), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, IOP.IOR s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static IOP.IOR Extract(CORBA.Any any)
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
			return "IDL:IOP/IOR:1.0";
		}

		public static IOP.IOR Read(CORBA.IInputStream inputStream)
		{
			var result = new IOP.IOR();
			result.TypeId = inputStream.ReadString();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.Profiles = new IOP.TaggedProfile[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					IOP.TaggedProfile _item0;
					_item0 = IOP.TaggedProfileHelper.Read(inputStream);
					result.Profiles[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, IOP.IOR s)
		{
			outputStream.WriteString(s.TypeId);
			{
				outputStream.WriteLong(s.Profiles.Length);
				for (int i0 = 0; i0 < s.Profiles.Length; i0++)
				{
					IOP.TaggedProfileHelper.Write(outputStream, s.Profiles[i0]);
				}
			}
		}

	}
}