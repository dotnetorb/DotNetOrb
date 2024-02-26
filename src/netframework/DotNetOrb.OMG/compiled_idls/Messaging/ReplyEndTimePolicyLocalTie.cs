/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:33
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Messaging
{

	public class ReplyEndTimePolicyLocalTie: _ReplyEndTimePolicyLocalBase
	{
		public IReplyEndTimePolicyOperations _OperationsDelegate { get; set; }

		public ReplyEndTimePolicyLocalTie(IReplyEndTimePolicyOperations d)
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
		public override TimeBase.UtcT EndTime 
		{
			get
			{
				return _OperationsDelegate.EndTime;
			}
		}
	}
}