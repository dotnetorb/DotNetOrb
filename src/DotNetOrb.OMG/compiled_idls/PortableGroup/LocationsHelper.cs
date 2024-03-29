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
	public static class LocationsHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(LocationsHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateAliasTc(PortableGroup.LocationsHelper.Id(), "Locations", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().CreateSequenceTc(0, CosNaming.NameComponentHelper.Type())));
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CosNaming.NameComponent[][] value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static CosNaming.NameComponent[][] Extract(CORBA.Any any)
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
			return "IDL:omg.org/PortableGroup/Locations:1.0";
		}

		public static CosNaming.NameComponent[][] Read(CORBA.IInputStream inputStream)
		{
			CosNaming.NameComponent[][] result;
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result = new CosNaming.NameComponent[_capacity0][];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CosNaming.NameComponent[] _item0;
					{
						var _capacity1 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity1 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity1}");
						}
						_item0 = new CosNaming.NameComponent[_capacity1];
						for (int i1 = 0; i1 < _capacity1; i1++)
						{
							CosNaming.NameComponent _item1;
							_item1 = CosNaming.NameComponentHelper.Read(inputStream);
							_item0[i1] = _item1;
						}
					}
					result[i0] = _item0;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CosNaming.NameComponent[][] value)
		{
			{
				outputStream.WriteLong(value.Length);
				for (int i0 = 0; i0 < value.Length; i0++)
				{
					{
						outputStream.WriteLong(value[i0].Length);
						for (int i1 = 0; i1 < value[i0].Length; i1++)
						{
							CosNaming.NameComponentHelper.Write(outputStream, value[i0][i1]);
						}
					}
				}
			}
		}

	}
}
