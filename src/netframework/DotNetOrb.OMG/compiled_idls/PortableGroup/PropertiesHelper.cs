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
	public static class PropertiesHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(PropertiesHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(PortableGroup.PropertiesHelper.Id(), "Properties", CORBA.ORB.Init().CreateSequenceTc(0, PortableGroup.PropertyHelper.Type()));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, PortableGroup.Property[] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static PortableGroup.Property[] Extract(CORBA.Any any)
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
			return "IDL:omg.org/PortableGroup/Properties:1.0";
		}

		public static PortableGroup.Property[] Read(CORBA.IInputStream inputStream)
		{
			PortableGroup.Property[] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result = new PortableGroup.Property[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					PortableGroup.Property _item0;
					_item0 = PortableGroup.PropertyHelper.Read(inputStream);
					result[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, PortableGroup.Property[] value)
		{
			{
				outputStream.WriteLong(value.Length);
				for (int i0 = 0; i0 < value.Length; i0++)
				{
					PortableGroup.PropertyHelper.Write(outputStream, value[i0]);
				}
			}
		}

	}
}
