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

	public class CompressorFactoryLocalTie: _CompressorFactoryLocalBase
	{
		public ICompressorFactoryOperations _OperationsDelegate { get; set; }

		public CompressorFactoryLocalTie(ICompressorFactoryOperations d)
		{
			_OperationsDelegate = d;
		}

		public override ushort CompressorId 
		{
			get
			{
				return _OperationsDelegate.CompressorId;
			}
		}
		[IdlName("get_compressor")]
		public override Compression.ICompressor GetCompressor(ushort compressionLevel)
		{
			return _OperationsDelegate.GetCompressor(compressionLevel);
		}
	}
}
