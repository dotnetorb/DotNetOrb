/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace RTCORBA
{
	[IdlName("ServerProtocolPolicy")]
	[RepositoryID("IDL:RTCORBA/ServerProtocolPolicy:1.0")]
	[Helper(typeof(ServerProtocolPolicyHelper))]
	[Stub(typeof(_ServerProtocolPolicyLocalBase))]
	public interface IServerProtocolPolicy : CORBA.IIDLEntity, CORBA.ILocalInterface, IServerProtocolPolicyOperations, CORBA.IPolicy
	{
	}
}

