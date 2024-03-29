/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace GIOP
{
	public static class TargetAddressHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(TargetAddressHelper))
				{
					if (type == null)
					{
						var members = new List<CORBA.UnionMember>();
						CORBA.Any anyLabel;
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertShort(0);
						members.Add(new CORBA.UnionMember("object_key", anyLabel, CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null));
						type = CORBA.ORB.Init().CreateUnionTc(GIOP.TargetAddressHelper.Id(), "TargetAddress", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 4), members.ToArray());
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertShort(1);
						members.Add(new CORBA.UnionMember("profile", anyLabel, IOP.TaggedProfileHelper.Type(), null));
						type = CORBA.ORB.Init().CreateUnionTc(GIOP.TargetAddressHelper.Id(), "TargetAddress", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 4), members.ToArray());
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertShort(2);
						members.Add(new CORBA.UnionMember("ior", anyLabel, GIOP.IORAddressingInfoHelper.Type(), null));
						type = CORBA.ORB.Init().CreateUnionTc(GIOP.TargetAddressHelper.Id(), "TargetAddress", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 4), members.ToArray());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, GIOP.TargetAddress value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static GIOP.TargetAddress Extract(CORBA.Any any)
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
		    return "IDL:GIOP/TargetAddress:1.0";
		}

		public static GIOP.TargetAddress Read(CORBA.IInputStream inputStream)
		{
			var result = new GIOP.TargetAddress();
			short disc;
			disc = inputStream.ReadShort();
			switch (disc)
			{
				case 0:
				{
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						var _array = new byte[_capacity0];
						inputStream.ReadOctetArray(ref _array, 0, _capacity0);
						result.ObjectKey = _array;
					}
					break;
				}
				case 1:
				{
					result.Profile = IOP.TaggedProfileHelper.Read(inputStream);
					break;
				}
				case 2:
				{
					result.Ior = GIOP.IORAddressingInfoHelper.Read(inputStream);
					break;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, GIOP.TargetAddress value)
		{
			outputStream.WriteShort(value._Discriminator);
			switch (value._Discriminator)
			{
				case 0:
				{
					{
						outputStream.WriteLong(value.ObjectKey.Length);
						outputStream.WriteOctetArray(value.ObjectKey, 0, value.ObjectKey.Length);
					}
					break;
				}
				case 1:
				{
					IOP.TaggedProfileHelper.Write(outputStream, value.Profile);
					break;
				}
				case 2:
				{
					GIOP.IORAddressingInfoHelper.Write(outputStream, value.Ior);
					break;
				}
			}
		}

	}
}
