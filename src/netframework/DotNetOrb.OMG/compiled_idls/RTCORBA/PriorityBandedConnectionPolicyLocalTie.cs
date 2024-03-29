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

	public class PriorityBandedConnectionPolicyLocalTie: _PriorityBandedConnectionPolicyLocalBase
	{
		public IPriorityBandedConnectionPolicyOperations _OperationsDelegate { get; set; }

		public PriorityBandedConnectionPolicyLocalTie(IPriorityBandedConnectionPolicyOperations d)
		{
			_OperationsDelegate = d;
		}

		public override uint PolicyType 
		{
			get
			{
				return _OperationsDelegate.PolicyType;
			}
		}
		[IdlName("copy")]
		public override CORBA.IPolicy Copy()
		{
			return _OperationsDelegate.Copy();
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
		public override RTCORBA.PriorityBand[] PriorityBands 
		{
			get
			{
				return _OperationsDelegate.PriorityBands;
			}
		}
	}
}
