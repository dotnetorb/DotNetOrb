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
	public interface ITCPProtocolPropertiesOperations : RTCORBA.IProtocolPropertiesOperations
	{
		[IdlName("send_buffer_size")]
		public int SendBufferSize 
		{
			get;

			set;
		}
		[IdlName("recv_buffer_size")]
		public int RecvBufferSize 
		{
			get;

			set;
		}
		[IdlName("keep_alive")]
		public bool KeepAlive 
		{
			get;

			set;
		}
		[IdlName("dont_route")]
		public bool DontRoute 
		{
			get;

			set;
		}
		[IdlName("no_delay")]
		public bool NoDelay 
		{
			get;

			set;
		}
	}
}

