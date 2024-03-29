/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{

	public class ThreadPolicyLocalTie: _ThreadPolicyLocalBase
	{
		public IThreadPolicyOperations _OperationsDelegate { get; set; }

		public ThreadPolicyLocalTie(IThreadPolicyOperations d)
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
		public override PortableServer.ThreadPolicyValue Value 
		{
			get
			{
				return _OperationsDelegate.Value;
			}
		}
	}
}
