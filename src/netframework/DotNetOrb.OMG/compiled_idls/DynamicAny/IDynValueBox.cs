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
	[IdlName("DynValueBox")]
	[RepositoryID("IDL:DynamicAny/DynValueBox:1.0")]
	[Helper(typeof(DynValueBoxHelper))]
	[Stub(typeof(_DynValueBoxLocalBase))]
	public interface IDynValueBox : CORBA.IIDLEntity, CORBA.ILocalInterface, IDynValueBoxOperations, DynamicAny.IDynValueCommon
	{
	}
}
