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
	public abstract class _ReplyStartTimePolicyLocalBase: CORBA.LocalObject, IReplyStartTimePolicy
	{
		private string[] _ids = {"IDL:Messaging/ReplyStartTimePolicy:1.0","IDL:CORBA/Policy:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("policy_type")]
		public abstract uint PolicyType 
		{
			get;
		}
		[IdlName("copy")]
		public abstract CORBA.IPolicy Copy();
		[IdlName("destroy")]
		public abstract void Destroy();
		[IdlName("start_time")]
		public abstract TimeBase.UtcT StartTime 
		{
			get;
		}
	}

}
