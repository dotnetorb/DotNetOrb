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
	[IdlName("ConnectionZeroCopy")]
	[RepositoryID("IDL:omg.org/ETF/ConnectionZeroCopy:1.0")]
	[Helper(typeof(ConnectionZeroCopyHelper))]
	[Stub(typeof(_ConnectionZeroCopyLocalBase))]
	public interface IConnectionZeroCopy : CORBA.IIDLEntity, CORBA.ILocalInterface, IConnectionZeroCopyOperations, ETF.IConnection
	{
	}
}

