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
	[IdlName("CompressionManager")]
	[RepositoryID("IDL:omg.org/Compression/CompressionManager:1.0")]
	[Helper(typeof(CompressionManagerHelper))]
	[Stub(typeof(_CompressionManagerLocalBase))]
	public interface ICompressionManager : CORBA.IIDLEntity, CORBA.ILocalInterface, ICompressionManagerOperations
	{
	}
}

