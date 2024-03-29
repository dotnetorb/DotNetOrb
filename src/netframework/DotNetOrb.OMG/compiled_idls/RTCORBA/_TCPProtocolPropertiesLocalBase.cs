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
	public abstract class _TCPProtocolPropertiesLocalBase: CORBA.LocalObject, ITCPProtocolProperties
	{
		private string[] _ids = {"IDL:RTCORBA/TCPProtocolProperties:1.0","IDL:RTCORBA/ProtocolProperties:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("send_buffer_size")]
		public abstract int SendBufferSize 
		{
			get;

			set;
		}
		[IdlName("recv_buffer_size")]
		public abstract int RecvBufferSize 
		{
			get;

			set;
		}
		[IdlName("keep_alive")]
		public abstract bool KeepAlive 
		{
			get;

			set;
		}
		[IdlName("dont_route")]
		public abstract bool DontRoute 
		{
			get;

			set;
		}
		[IdlName("no_delay")]
		public abstract bool NoDelay 
		{
			get;

			set;
		}
	}

}
