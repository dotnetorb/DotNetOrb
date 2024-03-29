/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public interface IPolicyManagerOperations
	{
		[IdlName("get_policy_overrides")]
		public CORBA.IPolicy[] GetPolicyOverrides(uint[] ts);
		[IdlName("set_policy_overrides")]
		[ThrowsIdlException(typeof(CORBA.InvalidPolicies))]
		public void SetPolicyOverrides(CORBA.IPolicy[] policies, CORBA.SetOverrideType setAdd);
	}
}

