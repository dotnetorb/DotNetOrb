/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableInterceptor
{

	public class PolicyFactoryLocalTie: _PolicyFactoryLocalBase
	{
		public IPolicyFactoryOperations _OperationsDelegate { get; set; }

		public PolicyFactoryLocalTie(IPolicyFactoryOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("create_policy")]
		[ThrowsIdlException(typeof(CORBA.PolicyError))]
		public override CORBA.IPolicy CreatePolicy(uint type, CORBA.Any value)
		{
			return _OperationsDelegate.CreatePolicy(type, value);
		}
	}
}
