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

	public class DynArrayLocalTie: _DynArrayLocalBase
	{
		public IDynArrayOperations _OperationsDelegate { get; set; }

		public DynArrayLocalTie(IDynArrayOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("type")]
		public override CORBA.TypeCode Type()
		{
			return _OperationsDelegate.Type();
		}
		[IdlName("assign")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		public override void Assign(DynamicAny.IDynAny dynAny)
		{
			_OperationsDelegate.Assign(dynAny);
		}
		[IdlName("from_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void FromAny(CORBA.Any value)
		{
			_OperationsDelegate.FromAny(value);
		}
		[IdlName("to_any")]
		public override CORBA.Any ToAny()
		{
			return _OperationsDelegate.ToAny();
		}
		[IdlName("equal")]
		public override bool Equal(DynamicAny.IDynAny dynAny)
		{
			return _OperationsDelegate.Equal(dynAny);
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
		[IdlName("copy")]
		public override DynamicAny.IDynAny Copy()
		{
			return _OperationsDelegate.Copy();
		}
		[IdlName("insert_boolean")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertBoolean(bool value)
		{
			_OperationsDelegate.InsertBoolean(value);
		}
		[IdlName("insert_octet")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertOctet(byte value)
		{
			_OperationsDelegate.InsertOctet(value);
		}
		[IdlName("insert_char")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertChar(char value)
		{
			_OperationsDelegate.InsertChar(value);
		}
		[IdlName("insert_short")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertShort(short value)
		{
			_OperationsDelegate.InsertShort(value);
		}
		[IdlName("insert_ushort")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertUshort(ushort value)
		{
			_OperationsDelegate.InsertUshort(value);
		}
		[IdlName("insert_long")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertLong(int value)
		{
			_OperationsDelegate.InsertLong(value);
		}
		[IdlName("insert_ulong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertUlong(uint value)
		{
			_OperationsDelegate.InsertUlong(value);
		}
		[IdlName("insert_float")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertFloat(float value)
		{
			_OperationsDelegate.InsertFloat(value);
		}
		[IdlName("insert_double")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertDouble(double value)
		{
			_OperationsDelegate.InsertDouble(value);
		}
		[IdlName("insert_string")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertString([WideChar(false)] string value)
		{
			_OperationsDelegate.InsertString(value);
		}
		[IdlName("insert_reference")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertReference(CORBA.IObject value)
		{
			_OperationsDelegate.InsertReference(value);
		}
		[IdlName("insert_typecode")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertTypecode(CORBA.TypeCode value)
		{
			_OperationsDelegate.InsertTypecode(value);
		}
		[IdlName("insert_longlong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertLonglong(long value)
		{
			_OperationsDelegate.InsertLonglong(value);
		}
		[IdlName("insert_ulonglong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertUlonglong(ulong value)
		{
			_OperationsDelegate.InsertUlonglong(value);
		}
		[IdlName("insert_longdouble")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertLongdouble(decimal value)
		{
			_OperationsDelegate.InsertLongdouble(value);
		}
		[IdlName("insert_wchar")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertWchar(char value)
		{
			_OperationsDelegate.InsertWchar(value);
		}
		[IdlName("insert_wstring")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertWstring([WideChar(true)] string value)
		{
			_OperationsDelegate.InsertWstring(value);
		}
		[IdlName("insert_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertAny(CORBA.Any value)
		{
			_OperationsDelegate.InsertAny(value);
		}
		[IdlName("insert_dyn_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertDynAny(DynamicAny.IDynAny value)
		{
			_OperationsDelegate.InsertDynAny(value);
		}
		[IdlName("insert_val")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertVal(object value)
		{
			_OperationsDelegate.InsertVal(value);
		}
		[IdlName("get_boolean")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override bool GetBoolean()
		{
			return _OperationsDelegate.GetBoolean();
		}
		[IdlName("get_octet")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override byte GetOctet()
		{
			return _OperationsDelegate.GetOctet();
		}
		[IdlName("get_char")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override char GetChar()
		{
			return _OperationsDelegate.GetChar();
		}
		[IdlName("get_short")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override short GetShort()
		{
			return _OperationsDelegate.GetShort();
		}
		[IdlName("get_ushort")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override ushort GetUshort()
		{
			return _OperationsDelegate.GetUshort();
		}
		[IdlName("get_long")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override int GetLong()
		{
			return _OperationsDelegate.GetLong();
		}
		[IdlName("get_ulong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override uint GetUlong()
		{
			return _OperationsDelegate.GetUlong();
		}
		[IdlName("get_float")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override float GetFloat()
		{
			return _OperationsDelegate.GetFloat();
		}
		[IdlName("get_double")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override double GetDouble()
		{
			return _OperationsDelegate.GetDouble();
		}
		[IdlName("get_string")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		[return: WideChar(false)]
		public override string GetString()
		{
			return _OperationsDelegate.GetString();
		}
		[IdlName("get_reference")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override CORBA.IObject GetReference()
		{
			return _OperationsDelegate.GetReference();
		}
		[IdlName("get_typecode")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override CORBA.TypeCode GetTypecode()
		{
			return _OperationsDelegate.GetTypecode();
		}
		[IdlName("get_longlong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override long GetLonglong()
		{
			return _OperationsDelegate.GetLonglong();
		}
		[IdlName("get_ulonglong")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override ulong GetUlonglong()
		{
			return _OperationsDelegate.GetUlonglong();
		}
		[IdlName("get_longdouble")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override decimal GetLongdouble()
		{
			return _OperationsDelegate.GetLongdouble();
		}
		[IdlName("get_wchar")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override char GetWchar()
		{
			return _OperationsDelegate.GetWchar();
		}
		[IdlName("get_wstring")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		[return: WideChar(true)]
		public override string GetWstring()
		{
			return _OperationsDelegate.GetWstring();
		}
		[IdlName("get_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override CORBA.Any GetAny()
		{
			return _OperationsDelegate.GetAny();
		}
		[IdlName("get_dyn_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override DynamicAny.IDynAny GetDynAny()
		{
			return _OperationsDelegate.GetDynAny();
		}
		[IdlName("get_val")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override object GetVal()
		{
			return _OperationsDelegate.GetVal();
		}
		[IdlName("seek")]
		public override bool Seek(int index)
		{
			return _OperationsDelegate.Seek(index);
		}
		[IdlName("rewind")]
		public override void Rewind()
		{
			_OperationsDelegate.Rewind();
		}
		[IdlName("next")]
		public override bool Next()
		{
			return _OperationsDelegate.Next();
		}
		[IdlName("component_count")]
		public override uint ComponentCount()
		{
			return _OperationsDelegate.ComponentCount();
		}
		[IdlName("current_component")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		public override DynamicAny.IDynAny CurrentComponent()
		{
			return _OperationsDelegate.CurrentComponent();
		}
		[IdlName("insert_boolean_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertBooleanSeq(bool[] value)
		{
			_OperationsDelegate.InsertBooleanSeq(value);
		}
		[IdlName("insert_octet_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertOctetSeq(byte[] value)
		{
			_OperationsDelegate.InsertOctetSeq(value);
		}
		[IdlName("insert_char_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertCharSeq(char[] value)
		{
			_OperationsDelegate.InsertCharSeq(value);
		}
		[IdlName("insert_short_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertShortSeq(short[] value)
		{
			_OperationsDelegate.InsertShortSeq(value);
		}
		[IdlName("insert_ushort_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertUshortSeq(ushort[] value)
		{
			_OperationsDelegate.InsertUshortSeq(value);
		}
		[IdlName("insert_long_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertLongSeq(int[] value)
		{
			_OperationsDelegate.InsertLongSeq(value);
		}
		[IdlName("insert_ulong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertUlongSeq(uint[] value)
		{
			_OperationsDelegate.InsertUlongSeq(value);
		}
		[IdlName("insert_float_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertFloatSeq(float[] value)
		{
			_OperationsDelegate.InsertFloatSeq(value);
		}
		[IdlName("insert_double_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertDoubleSeq(double[] value)
		{
			_OperationsDelegate.InsertDoubleSeq(value);
		}
		[IdlName("insert_longlong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertLonglongSeq(long[] value)
		{
			_OperationsDelegate.InsertLonglongSeq(value);
		}
		[IdlName("insert_ulonglong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertUlonglongSeq(ulong[] value)
		{
			_OperationsDelegate.InsertUlonglongSeq(value);
		}
		[IdlName("insert_longdouble_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertLongdoubleSeq(decimal[] value)
		{
			_OperationsDelegate.InsertLongdoubleSeq(value);
		}
		[IdlName("insert_wchar_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void InsertWcharSeq(char[] value)
		{
			_OperationsDelegate.InsertWcharSeq(value);
		}
		[IdlName("get_boolean_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override bool[] GetBooleanSeq()
		{
			return _OperationsDelegate.GetBooleanSeq();
		}
		[IdlName("get_octet_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override byte[] GetOctetSeq()
		{
			return _OperationsDelegate.GetOctetSeq();
		}
		[IdlName("get_char_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override char[] GetCharSeq()
		{
			return _OperationsDelegate.GetCharSeq();
		}
		[IdlName("get_short_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override short[] GetShortSeq()
		{
			return _OperationsDelegate.GetShortSeq();
		}
		[IdlName("get_ushort_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override ushort[] GetUshortSeq()
		{
			return _OperationsDelegate.GetUshortSeq();
		}
		[IdlName("get_long_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override int[] GetLongSeq()
		{
			return _OperationsDelegate.GetLongSeq();
		}
		[IdlName("get_ulong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override uint[] GetUlongSeq()
		{
			return _OperationsDelegate.GetUlongSeq();
		}
		[IdlName("get_float_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override float[] GetFloatSeq()
		{
			return _OperationsDelegate.GetFloatSeq();
		}
		[IdlName("get_double_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override double[] GetDoubleSeq()
		{
			return _OperationsDelegate.GetDoubleSeq();
		}
		[IdlName("get_longlong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override long[] GetLonglongSeq()
		{
			return _OperationsDelegate.GetLonglongSeq();
		}
		[IdlName("get_ulonglong_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override ulong[] GetUlonglongSeq()
		{
			return _OperationsDelegate.GetUlonglongSeq();
		}
		[IdlName("get_longdouble_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override decimal[] GetLongdoubleSeq()
		{
			return _OperationsDelegate.GetLongdoubleSeq();
		}
		[IdlName("get_wchar_seq")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override char[] GetWcharSeq()
		{
			return _OperationsDelegate.GetWcharSeq();
		}
		[IdlName("get_elements")]
		public override CORBA.Any[] GetElements()
		{
			return _OperationsDelegate.GetElements();
		}
		[IdlName("set_elements")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void SetElements(CORBA.Any[] value)
		{
			_OperationsDelegate.SetElements(value);
		}
		[IdlName("get_elements_as_dyn_any")]
		public override DynamicAny.IDynAny[] GetElementsAsDynAny()
		{
			return _OperationsDelegate.GetElementsAsDynAny();
		}
		[IdlName("set_elements_as_dyn_any")]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.TypeMismatch))]
		[ThrowsIdlException(typeof(DynamicAny.DynAny.InvalidValue))]
		public override void SetElementsAsDynAny(DynamicAny.IDynAny[] value)
		{
			_OperationsDelegate.SetElementsAsDynAny(value);
		}
	}
}
