/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace ETF
{
	[IdlName("BufferList")]
	[RepositoryID("IDL:omg.org/ETF/BufferList:1.0")]
	[Helper(typeof(BufferListHelper))]
	[Stub(typeof(_BufferListLocalBase))]
	public interface IBufferList : CORBA.IIDLEntity, CORBA.ILocalInterface, IBufferListOperations
	{
	}
}
