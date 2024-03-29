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
	public interface IRequestInfoOperations
	{
		[IdlName("request_id")]
		public uint RequestId 
		{
			get;
		}
		[IdlName("operation")]
		[WideChar(false)]
		public string Operation 
		{
			get;
		}
		[IdlName("arguments")]
		public Dynamic.Parameter[] Arguments 
		{
			get;
		}
		[IdlName("exceptions")]
		public CORBA.TypeCode[] Exceptions 
		{
			get;
		}
		[IdlName("contexts")]
		public string[] Contexts 
		{
			get;
		}
		[IdlName("operation_context")]
		public string[] OperationContext 
		{
			get;
		}
		[IdlName("result")]
		public CORBA.Any Result 
		{
			get;
		}
		[IdlName("response_expected")]
		public bool ResponseExpected 
		{
			get;
		}
		[IdlName("sync_scope")]
		public short SyncScope 
		{
			get;
		}
		[IdlName("reply_status")]
		public short ReplyStatus 
		{
			get;
		}
		[IdlName("forward_reference")]
		public CORBA.IObject ForwardReference 
		{
			get;
		}
		[IdlName("get_slot")]
		[ThrowsIdlException(typeof(PortableInterceptor.InvalidSlot))]
		public CORBA.Any GetSlot(uint id);
		[IdlName("get_request_service_context")]
		public IOP.ServiceContext GetRequestServiceContext(uint id);
		[IdlName("get_reply_service_context")]
		public IOP.ServiceContext GetReplyServiceContext(uint id);
	}
}

