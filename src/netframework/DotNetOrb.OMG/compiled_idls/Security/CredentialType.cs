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
	[IdlName("CredentialType")]
	[RepositoryID("IDL:omg.org/Security/CredentialType:1.0")]
	[Helper(typeof(CredentialTypeHelper))]
	public enum CredentialType
	{
		[IdlName("SecInvocationCredentials")]
		SecInvocationCredentials = 0,
		[IdlName("SecNRCredentials")]
		SecNRCredentials = 1,
	}

}