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
	public abstract class _MutexLocalBase: CORBA.LocalObject, IMutex
	{
		private string[] _ids = {"IDL:RTCORBA/Mutex:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("lock")]
		public abstract void Lock();
		[IdlName("unlock")]
		public abstract void Unlock();
		[IdlName("try_lock")]
		public abstract bool TryLock(ulong maxWait);
	}

}
