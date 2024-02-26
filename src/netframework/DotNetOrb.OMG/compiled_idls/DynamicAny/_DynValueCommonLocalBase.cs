/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:38
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DynamicAny
{
	public abstract class _DynValueCommonLocalBase: CORBA.LocalObject, IDynValueCommon
	{
		private string[] _ids = {"IDL:DynamicAny/DynValueCommon:1.0","IDL:DynamicAny/DynAny:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("type")]
		public abstract CORBA.TypeCode Type();
		[IdlName("assign")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		public abstract void Assign(DynamicAny.IDynAny dynAny);
		[IdlName("from_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void FromAny(CORBA.Any value);
		[IdlName("to_any")]
		public abstract CORBA.Any ToAny();
		[IdlName("equal")]
		public abstract bool Equal(DynamicAny.IDynAny dynAny);
		[IdlName("destroy")]
		public abstract void Destroy();
		[IdlName("copy")]
		public abstract DynamicAny.IDynAny Copy();
		[IdlName("insert_boolean")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertBoolean(bool value);
		[IdlName("insert_octet")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertOctet(byte value);
		[IdlName("insert_char")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertChar(char value);
		[IdlName("insert_short")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertShort(short value);
		[IdlName("insert_ushort")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertUshort(ushort value);
		[IdlName("insert_long")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertLong(int value);
		[IdlName("insert_ulong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertUlong(uint value);
		[IdlName("insert_float")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertFloat(float value);
		[IdlName("insert_double")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertDouble(double value);
		[IdlName("insert_string")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertString([WideChar(false)] string value);
		[IdlName("insert_reference")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertReference(CORBA.IObject value);
		[IdlName("insert_typecode")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertTypecode(CORBA.TypeCode value);
		[IdlName("insert_longlong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertLonglong(long value);
		[IdlName("insert_ulonglong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertUlonglong(ulong value);
		[IdlName("insert_longdouble")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertLongdouble(decimal value);
		[IdlName("insert_wchar")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertWchar(char value);
		[IdlName("insert_wstring")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertWstring([WideChar(true)] string value);
		[IdlName("insert_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertAny(CORBA.Any value);
		[IdlName("insert_dyn_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertDynAny(DynamicAny.IDynAny value);
		[IdlName("insert_val")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertVal(object value);
		[IdlName("get_boolean")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract bool GetBoolean();
		[IdlName("get_octet")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract byte GetOctet();
		[IdlName("get_char")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract char GetChar();
		[IdlName("get_short")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract short GetShort();
		[IdlName("get_ushort")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract ushort GetUshort();
		[IdlName("get_long")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract int GetLong();
		[IdlName("get_ulong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract uint GetUlong();
		[IdlName("get_float")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract float GetFloat();
		[IdlName("get_double")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract double GetDouble();
		[IdlName("get_string")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		[return: WideChar(false)]
		public abstract string GetString();
		[IdlName("get_reference")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract CORBA.IObject GetReference();
		[IdlName("get_typecode")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract CORBA.TypeCode GetTypecode();
		[IdlName("get_longlong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract long GetLonglong();
		[IdlName("get_ulonglong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract ulong GetUlonglong();
		[IdlName("get_longdouble")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract decimal GetLongdouble();
		[IdlName("get_wchar")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract char GetWchar();
		[IdlName("get_wstring")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		[return: WideChar(true)]
		public abstract string GetWstring();
		[IdlName("get_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract CORBA.Any GetAny();
		[IdlName("get_dyn_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract DynamicAny.IDynAny GetDynAny();
		[IdlName("get_val")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract object GetVal();
		[IdlName("seek")]
		public abstract bool Seek(int index);
		[IdlName("rewind")]
		public abstract void Rewind();
		[IdlName("next")]
		public abstract bool Next();
		[IdlName("component_count")]
		public abstract uint ComponentCount();
		[IdlName("current_component")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		public abstract DynamicAny.IDynAny CurrentComponent();
		[IdlName("insert_boolean_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertBooleanSeq(bool[] value);
		[IdlName("insert_octet_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertOctetSeq(byte[] value);
		[IdlName("insert_char_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertCharSeq(char[] value);
		[IdlName("insert_short_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertShortSeq(short[] value);
		[IdlName("insert_ushort_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertUshortSeq(ushort[] value);
		[IdlName("insert_long_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertLongSeq(int[] value);
		[IdlName("insert_ulong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertUlongSeq(uint[] value);
		[IdlName("insert_float_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertFloatSeq(float[] value);
		[IdlName("insert_double_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertDoubleSeq(double[] value);
		[IdlName("insert_longlong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertLonglongSeq(long[] value);
		[IdlName("insert_ulonglong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertUlonglongSeq(ulong[] value);
		[IdlName("insert_longdouble_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertLongdoubleSeq(decimal[] value);
		[IdlName("insert_wchar_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract void InsertWcharSeq(char[] value);
		[IdlName("get_boolean_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract bool[] GetBooleanSeq();
		[IdlName("get_octet_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract byte[] GetOctetSeq();
		[IdlName("get_char_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract char[] GetCharSeq();
		[IdlName("get_short_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract short[] GetShortSeq();
		[IdlName("get_ushort_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract ushort[] GetUshortSeq();
		[IdlName("get_long_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract int[] GetLongSeq();
		[IdlName("get_ulong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract uint[] GetUlongSeq();
		[IdlName("get_float_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract float[] GetFloatSeq();
		[IdlName("get_double_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract double[] GetDoubleSeq();
		[IdlName("get_longlong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract long[] GetLonglongSeq();
		[IdlName("get_ulonglong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract ulong[] GetUlonglongSeq();
		[IdlName("get_longdouble_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract decimal[] GetLongdoubleSeq();
		[IdlName("get_wchar_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public abstract char[] GetWcharSeq();
		[IdlName("is_null")]
		public abstract bool IsNull();
		[IdlName("set_to_null")]
		public abstract void SetToNull();
		[IdlName("set_to_value")]
		public abstract void SetToValue();
	}

}
