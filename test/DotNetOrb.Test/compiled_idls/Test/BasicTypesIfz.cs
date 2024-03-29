/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Test
{
	public abstract partial class BasicTypesIfz : CORBA.Object, Test.IBasicTypesIfz
	{
		public static class FixedTHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(FixedTHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.FixedTHelper.Id(), "fixedT", ORB.Init().CreateFixedTc(5, 2));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, Decimal value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static Decimal Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/fixedT:1.0";
			}

			public static Decimal Read(CORBA.IInputStream inputStream)
			{
				Decimal result;
				result = inputStream.ReadFixed(5, 2);
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, Decimal value)
			{
				outputStream.WriteFixed(value, 5, 2);
			}

		}
		public static class SbyteSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(SbyteSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.SbyteSeqHelper.Id(), "SbyteSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, sbyte[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static sbyte[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/SbyteSeq:1.0";
			}

			public static sbyte[] Read(CORBA.IInputStream inputStream)
			{
				sbyte[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					result = new sbyte[_capacity0];
					for (int i0 = 0; i0 < _capacity0; i0++)
					{
						sbyte _item0;
						_item0 = (sbyte) inputStream.ReadOctet();
						result[i0] = _item0;
					}
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, sbyte[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					for (int i0 = 0; i0 < value.Length; i0++)
					{
						outputStream.WriteOctet((byte) value[i0]);
					}
				}
			}

		}
		public static class ByteSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ByteSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.ByteSeqHelper.Id(), "ByteSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, byte[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static byte[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/ByteSeq:1.0";
			}

			public static byte[] Read(CORBA.IInputStream inputStream)
			{
				byte[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new byte[_capacity0];
					inputStream.ReadOctetArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, byte[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteOctetArray(value, 0, value.Length);
				}
			}

		}
		public static class ShortSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ShortSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.ShortSeqHelper.Id(), "ShortSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 4)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, short[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static short[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/ShortSeq:1.0";
			}

			public static short[] Read(CORBA.IInputStream inputStream)
			{
				short[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new short[_capacity0];
					inputStream.ReadShortArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, short[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteShortArray(value, 0, value.Length);
				}
			}

		}
		public static class UshortSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(UshortSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.UshortSeqHelper.Id(), "UshortSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 2)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, ushort[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static ushort[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/UshortSeq:1.0";
			}

			public static ushort[] Read(CORBA.IInputStream inputStream)
			{
				ushort[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new ushort[_capacity0];
					inputStream.ReadUShortArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, ushort[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteUShortArray(value, 0, value.Length);
				}
			}

		}
		public static class LongSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(LongSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.LongSeqHelper.Id(), "LongSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 3)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, int[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static int[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/LongSeq:1.0";
			}

			public static int[] Read(CORBA.IInputStream inputStream)
			{
				int[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new int[_capacity0];
					inputStream.ReadLongArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, int[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteLongArray(value, 0, value.Length);
				}
			}

		}
		public static class UlongSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(UlongSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.UlongSeqHelper.Id(), "UlongSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, uint[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static uint[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/UlongSeq:1.0";
			}

			public static uint[] Read(CORBA.IInputStream inputStream)
			{
				uint[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new uint[_capacity0];
					inputStream.ReadULongArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, uint[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteULongArray(value, 0, value.Length);
				}
			}

		}
		public static class LongLongSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(LongLongSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.LongLongSeqHelper.Id(), "LongLongSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 23)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, long[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static long[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/LongLongSeq:1.0";
			}

			public static long[] Read(CORBA.IInputStream inputStream)
			{
				long[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new long[_capacity0];
					inputStream.ReadLongLongArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, long[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteLongLongArray(value, 0, value.Length);
				}
			}

		}
		public static class UlongSongSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(UlongSongSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.UlongSongSeqHelper.Id(), "UlongSongSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 24)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, ulong[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static ulong[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/UlongSongSeq:1.0";
			}

			public static ulong[] Read(CORBA.IInputStream inputStream)
			{
				ulong[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new ulong[_capacity0];
					inputStream.ReadULongLongArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, ulong[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteULongLongArray(value, 0, value.Length);
				}
			}

		}
		public static class FloatSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(FloatSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.FloatSeqHelper.Id(), "FloatSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 6)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, float[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static float[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/FloatSeq:1.0";
			}

			public static float[] Read(CORBA.IInputStream inputStream)
			{
				float[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new float[_capacity0];
					inputStream.ReadFloatArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, float[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteFloatArray(value, 0, value.Length);
				}
			}

		}
		public static class DoubleSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(DoubleSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.DoubleSeqHelper.Id(), "DoubleSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 7)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, double[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static double[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/DoubleSeq:1.0";
			}

			public static double[] Read(CORBA.IInputStream inputStream)
			{
				double[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new double[_capacity0];
					inputStream.ReadDoubleArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, double[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteDoubleArray(value, 0, value.Length);
				}
			}

		}
		public static class CharSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(CharSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.CharSeqHelper.Id(), "CharSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 9)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, char[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static char[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/CharSeq:1.0";
			}

			public static char[] Read(CORBA.IInputStream inputStream)
			{
				char[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new char[_capacity0];
					inputStream.ReadCharArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, char[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteCharArray(value, 0, value.Length);
				}
			}

		}
		public static class WCharSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(WCharSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.WCharSeqHelper.Id(), "WCharSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 26)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, char[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static char[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/WCharSeq:1.0";
			}

			public static char[] Read(CORBA.IInputStream inputStream)
			{
				char[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new char[_capacity0];
					inputStream.ReadWCharArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, char[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteWCharArray(value, 0, value.Length);
				}
			}

		}
		public static class StringSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(StringSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.StringSeqHelper.Id(), "StringSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().CreateStringTc(0)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, string[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static string[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/StringSeq:1.0";
			}

			public static string[] Read(CORBA.IInputStream inputStream)
			{
				string[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					result = new string[_capacity0];
					for (int i0 = 0; i0 < _capacity0; i0++)
					{
						string _item0;
						_item0 = inputStream.ReadString();
						result[i0] = _item0;
					}
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, string[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					for (int i0 = 0; i0 < value.Length; i0++)
					{
						outputStream.WriteString(value[i0]);
					}
				}
			}

		}
		public static class WStringSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(WStringSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.WStringSeqHelper.Id(), "WStringSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().CreateStringTc(0)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, string[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static string[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/WStringSeq:1.0";
			}

			public static string[] Read(CORBA.IInputStream inputStream)
			{
				string[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					result = new string[_capacity0];
					for (int i0 = 0; i0 < _capacity0; i0++)
					{
						string _item0;
						_item0 = inputStream.ReadWString();
						result[i0] = _item0;
					}
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, string[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					for (int i0 = 0; i0 < value.Length; i0++)
					{
						outputStream.WriteWString(value[i0]);
					}
				}
			}

		}
		public static class BoolSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(BoolSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.BoolSeqHelper.Id(), "BoolSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 8)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, bool[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static bool[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/BoolSeq:1.0";
			}

			public static bool[] Read(CORBA.IInputStream inputStream)
			{
				bool[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new bool[_capacity0];
					inputStream.ReadBooleanArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, bool[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteBooleanArray(value, 0, value.Length);
				}
			}

		}
		public static class OctetSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(OctetSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.OctetSeqHelper.Id(), "OctetSeq", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, byte[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static byte[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/OctetSeq:1.0";
			}

			public static byte[] Read(CORBA.IInputStream inputStream)
			{
				byte[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					var _array = new byte[_capacity0];
					inputStream.ReadOctetArray(ref _array, 0, _capacity0);
					result = _array;
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, byte[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					outputStream.WriteOctetArray(value, 0, value.Length);
				}
			}

		}
		public static class FixedSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(FixedSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(Test.BasicTypesIfz.FixedSeqHelper.Id(), "FixedSeq", CORBA.ORB.Init().CreateSequenceTc(0, ORB.Init().CreateFixedTc(5, 2)));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, Decimal[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static Decimal[] Extract(CORBA.Any any)
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
				return "IDL:Test/BasicTypesIfz/FixedSeq:1.0";
			}

			public static Decimal[] Read(CORBA.IInputStream inputStream)
			{
				Decimal[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					result = new Decimal[_capacity0];
					for (int i0 = 0; i0 < _capacity0; i0++)
					{
						Decimal _item0;
						_item0 = inputStream.ReadFixed(5, 2);
						result[i0] = _item0;
					}
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, Decimal[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					for (int i0 = 0; i0 < value.Length; i0++)
					{
						outputStream.WriteFixed(value[i0], 5, 2);
					}
				}
			}

		}
		[IdlName("a_sbyte")]
		public abstract sbyte ASbyte 
		{
			get;

			set;
		}
		[IdlName("a_sbyte_seq")]
		public abstract sbyte[] ASbyteSeq 
		{
			get;

			set;
		}
		[IdlName("a_byte")]
		public abstract byte AByte 
		{
			get;

			set;
		}
		[IdlName("a_byte_seq")]
		public abstract byte[] AByteSeq 
		{
			get;

			set;
		}
		[IdlName("a_short")]
		public abstract short AShort 
		{
			get;

			set;
		}
		[IdlName("a_short_seq")]
		public abstract short[] AShortSeq 
		{
			get;

			set;
		}
		[IdlName("a_ushort")]
		public abstract ushort AUshort 
		{
			get;

			set;
		}
		[IdlName("a_ushort_seq")]
		public abstract ushort[] AUshortSeq 
		{
			get;

			set;
		}
		[IdlName("a_long")]
		public abstract int ALong 
		{
			get;

			set;
		}
		[IdlName("a_long_seq")]
		public abstract int[] ALongSeq 
		{
			get;

			set;
		}
		[IdlName("a_ulong")]
		public abstract uint AUlong 
		{
			get;

			set;
		}
		[IdlName("a_ulong_seq")]
		public abstract uint[] AUlongSeq 
		{
			get;

			set;
		}
		[IdlName("a_long_long")]
		public abstract long ALongLong 
		{
			get;

			set;
		}
		[IdlName("a_long_long_seq")]
		public abstract long[] ALongLongSeq 
		{
			get;

			set;
		}
		[IdlName("a_ulong_long")]
		public abstract ulong AUlongLong 
		{
			get;

			set;
		}
		[IdlName("a_ulong_long_seq")]
		public abstract ulong[] AUlongLongSeq 
		{
			get;

			set;
		}
		[IdlName("a_float")]
		public abstract float AFloat 
		{
			get;

			set;
		}
		[IdlName("a_float_seq")]
		public abstract float[] AFloatSeq 
		{
			get;

			set;
		}
		[IdlName("a_double")]
		public abstract double ADouble 
		{
			get;

			set;
		}
		[IdlName("a_double_seq")]
		public abstract double[] ADoubleSeq 
		{
			get;

			set;
		}
		[IdlName("a_char")]
		public abstract char AChar 
		{
			get;

			set;
		}
		[IdlName("a_char_seq")]
		public abstract char[] ACharSeq 
		{
			get;

			set;
		}
		[IdlName("a_wchar")]
		public abstract char AWchar 
		{
			get;

			set;
		}
		[IdlName("a_wchar_seq")]
		public abstract char[] AWcharSeq 
		{
			get;

			set;
		}
		[IdlName("a_string")]
		[WideChar(false)]
		public abstract string AString 
		{
			get;

			set;
		}
		[IdlName("a_string_seq")]
		public abstract string[] AStringSeq 
		{
			get;

			set;
		}
		[IdlName("a_wstring")]
		[WideChar(true)]
		public abstract string AWstring 
		{
			get;

			set;
		}
		[IdlName("a_wstring_seq")]
		public abstract string[] AWstringSeq 
		{
			get;

			set;
		}
		[IdlName("a_boolean")]
		public abstract bool ABoolean 
		{
			get;

			set;
		}
		[IdlName("a_boolean_seq")]
		public abstract bool[] ABooleanSeq 
		{
			get;

			set;
		}
		[IdlName("a_octet")]
		public abstract byte AOctet 
		{
			get;

			set;
		}
		[IdlName("a_octet_seq")]
		public abstract byte[] AOctetSeq 
		{
			get;

			set;
		}
		[IdlName("a_fixed")]
		public abstract Decimal AFixed 
		{
			get;

			set;
		}
		[IdlName("a_fixed_seq")]
		public abstract Decimal[] AFixedSeq 
		{
			get;

			set;
		}
	}
}

