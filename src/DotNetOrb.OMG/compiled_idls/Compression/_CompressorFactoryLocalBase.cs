/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Compression
{
	public abstract class _CompressorFactoryLocalBase: CORBA.LocalObject, ICompressorFactory
	{
		private string[] _ids = {"IDL:omg.org/Compression/CompressorFactory:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("compressor_id")]
		public abstract ushort CompressorId 
		{
			get;
		}
		[IdlName("get_compressor")]
		public abstract Compression.ICompressor GetCompressor(ushort compressionLevel);
	}

}