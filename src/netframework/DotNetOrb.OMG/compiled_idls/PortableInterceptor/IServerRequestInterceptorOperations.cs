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
	public interface IServerRequestInterceptorOperations : PortableInterceptor.IInterceptorOperations
	{
		[IdlName("receive_request_service_contexts")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public void ReceiveRequestServiceContexts(PortableInterceptor.IServerRequestInfo ri);
		[IdlName("receive_request")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public void ReceiveRequest(PortableInterceptor.IServerRequestInfo ri);
		[IdlName("send_reply")]
		public void SendReply(PortableInterceptor.IServerRequestInfo ri);
		[IdlName("send_exception")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public void SendException(PortableInterceptor.IServerRequestInfo ri);
		[IdlName("send_other")]
		[ThrowsIdlException(typeof(PortableInterceptor.ForwardRequest))]
		public void SendOther(PortableInterceptor.IServerRequestInfo ri);
	}
}

