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
	public interface ICodecOperations
	{
		[IdlName("encode")]
		[ThrowsIdlException(typeof(IOP.Codec.InvalidTypeForEncoding))]
		public byte[] Encode(CORBA.Any data);
		[IdlName("decode")]
		[ThrowsIdlException(typeof(IOP.Codec.FormatMismatch))]
		public CORBA.Any Decode(byte[] data);
		[IdlName("encode_value")]
		[ThrowsIdlException(typeof(IOP.Codec.InvalidTypeForEncoding))]
		public byte[] EncodeValue(CORBA.Any data);
		[IdlName("decode_value")]
		[ThrowsIdlException(typeof(IOP.Codec.FormatMismatch))]
		[ThrowsIdlException(typeof(IOP.Codec.TypeMismatch))]
		public CORBA.Any DecodeValue(byte[] data, CORBA.TypeCode tc);
	}
}

