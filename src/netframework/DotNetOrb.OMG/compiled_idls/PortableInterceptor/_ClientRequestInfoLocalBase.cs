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
	public abstract class _ClientRequestInfoLocalBase: CORBA.LocalObject, IClientRequestInfo
	{
		private string[] _ids = {"IDL:PortableInterceptor/ClientRequestInfo:1.0","IDL:PortableInterceptor/RequestInfo:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("request_id")]
		public abstract uint RequestId 
		{
			get;
		}
		[IdlName("operation")]
		[WideChar(false)]
		public abstract string Operation 
		{
			get;
		}
		[IdlName("arguments")]
		public abstract Dynamic.Parameter[] Arguments 
		{
			get;
		}
		[IdlName("exceptions")]
		public abstract CORBA.TypeCode[] Exceptions 
		{
			get;
		}
		[IdlName("contexts")]
		public abstract string[] Contexts 
		{
			get;
		}
		[IdlName("operation_context")]
		public abstract string[] OperationContext 
		{
			get;
		}
		[IdlName("result")]
		public abstract CORBA.Any Result 
		{
			get;
		}
		[IdlName("response_expected")]
		public abstract bool ResponseExpected 
		{
			get;
		}
		[IdlName("sync_scope")]
		public abstract short SyncScope 
		{
			get;
		}
		[IdlName("reply_status")]
		public abstract short ReplyStatus 
		{
			get;
		}
		[IdlName("forward_reference")]
		public abstract CORBA.IObject ForwardReference 
		{
			get;
		}
		[IdlName("get_slot")]
		[ThrowsIdlException(typeof(PortableInterceptor.InvalidSlot))]
		public abstract CORBA.Any GetSlot(uint id);
		[IdlName("get_request_service_context")]
		public abstract IOP.ServiceContext GetRequestServiceContext(uint id);
		[IdlName("get_reply_service_context")]
		public abstract IOP.ServiceContext GetReplyServiceContext(uint id);
		[IdlName("target")]
		public abstract CORBA.IObject Target 
		{
			get;
		}
		[IdlName("effective_target")]
		public abstract CORBA.IObject EffectiveTarget 
		{
			get;
		}
		[IdlName("effective_profile")]
		public abstract IOP.TaggedProfile EffectiveProfile 
		{
			get;
		}
		[IdlName("received_exception")]
		public abstract CORBA.Any ReceivedException 
		{
			get;
		}
		[IdlName("received_exception_id")]
		[WideChar(false)]
		public abstract string ReceivedExceptionId 
		{
			get;
		}
		[IdlName("get_effective_component")]
		public abstract IOP.TaggedComponent GetEffectiveComponent(uint id);
		[IdlName("get_effective_components")]
		public abstract IOP.TaggedComponent[] GetEffectiveComponents(uint id);
		[IdlName("get_request_policy")]
		public abstract CORBA.IPolicy GetRequestPolicy(uint type);
		[IdlName("add_request_service_context")]
		public abstract void AddRequestServiceContext(IOP.ServiceContext serviceContext, bool replace);
	}

}
