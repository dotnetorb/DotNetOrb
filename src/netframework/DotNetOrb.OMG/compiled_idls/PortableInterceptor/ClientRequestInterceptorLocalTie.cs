/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableInterceptor
{

	public class ClientRequestInterceptorLocalTie: _ClientRequestInterceptorLocalBase
	{
		public IClientRequestInterceptorOperations _OperationsDelegate { get; set; }

		public ClientRequestInterceptorLocalTie(IClientRequestInterceptorOperations d)
		{
			_OperationsDelegate = d;
		}

		[WideChar(false)]
		public override string Name 
		{
			get
			{
				return _OperationsDelegate.Name;
			}
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
		[IdlName("send_request")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public override void SendRequest(PortableInterceptor.IClientRequestInfo ri)
		{
			_OperationsDelegate.SendRequest(ri);
		}
		[IdlName("send_poll")]
		public override void SendPoll(PortableInterceptor.IClientRequestInfo ri)
		{
			_OperationsDelegate.SendPoll(ri);
		}
		[IdlName("receive_reply")]
		public override void ReceiveReply(PortableInterceptor.IClientRequestInfo ri)
		{
			_OperationsDelegate.ReceiveReply(ri);
		}
		[IdlName("receive_exception")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public override void ReceiveException(PortableInterceptor.IClientRequestInfo ri)
		{
			_OperationsDelegate.ReceiveException(ri);
		}
		[IdlName("receive_other")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public override void ReceiveOther(PortableInterceptor.IClientRequestInfo ri)
		{
			_OperationsDelegate.ReceiveOther(ri);
		}
	}
}
