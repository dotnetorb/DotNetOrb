/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DotNetOrb.ImR
{
	[IdlName("Registration")]
	[RepositoryID("IDL:DotNetOrb/ImR/Registration:1.0")]
	[Helper(typeof(RegistrationHelper))]
	[Stub(typeof(_RegistrationStub))]
	public interface IRegistration : CORBA.IIDLEntity, CORBA.IObject, IRegistrationOperations
	{
	}
}

