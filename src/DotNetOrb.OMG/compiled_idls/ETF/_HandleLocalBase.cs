/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace ETF
{
	public abstract class _HandleLocalBase: CORBA.LocalObject, IHandle
	{
		private string[] _ids = {"IDL:omg.org/ETF/Handle:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("add_input")]
		public abstract bool AddInput(ETF.IConnection conn);
		[IdlName("signal_data_available")]
		public abstract void SignalDataAvailable(ETF.IConnection conn);
		[IdlName("closed_by_peer")]
		public abstract void ClosedByPeer(ETF.IConnection conn);
	}

}
