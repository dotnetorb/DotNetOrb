/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{
	public static class UnsupportedPropertyHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(UnsupportedPropertyHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateExceptionTc(PortableGroup.UnsupportedPropertyHelper.Id(), "UnsupportedProperty", new CORBA.StructMember[] {new CORBA.StructMember("nam", CORBA.ORB.Init().CreateSequenceTc(0, CosNaming.NameComponentHelper.Type()), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, PortableGroup.UnsupportedProperty e)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), e);
		}

		public static PortableGroup.UnsupportedProperty Extract(CORBA.Any any)
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
			return "IDL:omg.org/PortableGroup/UnsupportedProperty:1.0";
		}

		public static PortableGroup.UnsupportedProperty Read(CORBA.IInputStream inputStream)
		{
			var id = inputStream.ReadString();
			if (!id.Equals(Id()))
			{
				throw new CORBA.Marshal("Wrong id: " + id);
			}
			var result = new PortableGroup.UnsupportedProperty();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.Nam = new CosNaming.NameComponent[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CosNaming.NameComponent _item0;
					_item0 = CosNaming.NameComponentHelper.Read(inputStream);
					result.Nam[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, PortableGroup.UnsupportedProperty e)
		{
			outputStream.WriteString(Id());
			{
				outputStream.WriteLong(e.Nam.Length);
				for (int i0 = 0; i0 < e.Nam.Length; i0++)
				{
					CosNaming.NameComponentHelper.Write(outputStream, e.Nam[i0]);
				}
			}
		}

	}
}
