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
	[IdlName("ThreadPolicyValue")]
	[RepositoryID("IDL:PortableServer/ThreadPolicyValue:1.0")]
	[Helper(typeof(ThreadPolicyValueHelper))]
	public enum ThreadPolicyValue
	{
		[IdlName("ORB_CTRL_MODEL")]
		ORB_CTRL_MODEL = 0,
		[IdlName("SINGLE_THREAD_MODEL")]
		SINGLE_THREAD_MODEL = 1,
		[IdlName("MAIN_THREAD_MODEL")]
		MAIN_THREAD_MODEL = 2,
	}

}
