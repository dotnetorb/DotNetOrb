/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:26
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public interface IConstructionPolicyOperations : CORBA.IPolicyOperations
	{
		[IdlName("make_domain_manager")]
		public void MakeDomainManager(CORBA.IInterfaceDef objectType, bool constrPolicy);
	}
}

