/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Security
{
	[IdlName("InvocationCredentialsType")]
	[RepositoryID("IDL:omg.org/Security/InvocationCredentialsType:1.0")]
	[Helper(typeof(InvocationCredentialsTypeHelper))]
	public enum InvocationCredentialsType
	{
		[IdlName("SecOwnCredentials")]
		SecOwnCredentials = 0,
		[IdlName("SecReceivedCredentials")]
		SecReceivedCredentials = 1,
	}

}
