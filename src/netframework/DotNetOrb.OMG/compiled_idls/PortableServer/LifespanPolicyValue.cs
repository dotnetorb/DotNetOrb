/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{
	[IdlName("LifespanPolicyValue")]
	[RepositoryID("IDL:PortableServer/LifespanPolicyValue:1.0")]
	[Helper(typeof(LifespanPolicyValueHelper))]
	public enum LifespanPolicyValue
	{
		[IdlName("TRANSIENT")]
		TRANSIENT = 0,
		[IdlName("PERSISTENT")]
		PERSISTENT = 1,
	}

}
