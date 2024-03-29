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

	public class ConnectionLocalTie: _ConnectionLocalBase
	{
		public IConnectionOperations _OperationsDelegate { get; set; }

		public ConnectionLocalTie(IConnectionOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("write")]
		public override void Write(bool isFirst, bool isLast, byte[] data, uint offset, uint length, ulong timeOut)
		{
			_OperationsDelegate.Write(isFirst, isLast, data, offset, length, timeOut);
		}
		[IdlName("read")]
		public override uint Read(ref byte[] data, uint offset, uint minLength, uint maxLength, ulong timeOut)
		{
			return _OperationsDelegate.Read(ref data, offset, minLength, maxLength, timeOut);
		}
		[IdlName("flush")]
		public override void Flush()
		{
			_OperationsDelegate.Flush();
		}
		[IdlName("connect")]
		public override void Connect(ETF.IProfile serverProfile, ulong timeOut)
		{
			_OperationsDelegate.Connect(serverProfile, timeOut);
		}
		[IdlName("close")]
		public override void Close()
		{
			_OperationsDelegate.Close();
		}
		[IdlName("is_connected")]
		public override bool IsConnected()
		{
			return _OperationsDelegate.IsConnected();
		}
		[IdlName("get_server_profile")]
		public override ETF.IProfile GetServerProfile()
		{
			return _OperationsDelegate.GetServerProfile();
		}
		[IdlName("is_data_available")]
		public override bool IsDataAvailable()
		{
			return _OperationsDelegate.IsDataAvailable();
		}
		[IdlName("wait_next_data")]
		public override bool WaitNextData(ulong timeOut)
		{
			return _OperationsDelegate.WaitNextData(timeOut);
		}
		public override bool SupportsCallback 
		{
			get
			{
				return _OperationsDelegate.SupportsCallback;
			}
		}
		public override bool UseHandleTimeOut 
		{
			get
			{
				return _OperationsDelegate.UseHandleTimeOut;
			}
		}
	}
}
