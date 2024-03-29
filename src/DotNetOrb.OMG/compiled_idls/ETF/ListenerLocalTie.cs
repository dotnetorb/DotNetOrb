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

	public class ListenerLocalTie: _ListenerLocalBase
	{
		public IListenerOperations _OperationsDelegate { get; set; }

		public ListenerLocalTie(IListenerOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("set_handle")]
		public override void SetHandle(ETF.IHandle up)
		{
			_OperationsDelegate.SetHandle(up);
		}
		[IdlName("accept")]
		public override ETF.IConnection Accept()
		{
			return _OperationsDelegate.Accept();
		}
		[IdlName("listen")]
		public override void Listen()
		{
			_OperationsDelegate.Listen();
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
		[IdlName("completed_data")]
		public override void CompletedData(ETF.IConnection conn)
		{
			_OperationsDelegate.CompletedData(conn);
		}
		public override ETF.IProfile Endpoint 
		{
			get
			{
				return _OperationsDelegate.Endpoint;
			}
		}
	}
}
