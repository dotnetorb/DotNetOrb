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
	public abstract class _ConnectionLocalBase: CORBA.LocalObject, IConnection
	{
		private string[] _ids = {"IDL:omg.org/ETF/Connection:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("write")]
		public abstract void Write(bool isFirst, bool isLast, byte[] data, uint offset, uint length, ulong timeOut);
		[IdlName("read")]
		public abstract uint Read(ref byte[] data, uint offset, uint minLength, uint maxLength, ulong timeOut);
		[IdlName("flush")]
		public abstract void Flush();
		[IdlName("connect")]
		public abstract void Connect(ETF.IProfile serverProfile, ulong timeOut);
		[IdlName("close")]
		public abstract void Close();
		[IdlName("is_connected")]
		public abstract bool IsConnected();
		[IdlName("get_server_profile")]
		public abstract ETF.IProfile GetServerProfile();
		[IdlName("is_data_available")]
		public abstract bool IsDataAvailable();
		[IdlName("wait_next_data")]
		public abstract bool WaitNextData(ulong timeOut);
		[IdlName("supports_callback")]
		public abstract bool SupportsCallback 
		{
			get;
		}
		[IdlName("use_handle_time_out")]
		public abstract bool UseHandleTimeOut 
		{
			get;
		}
	}

}
