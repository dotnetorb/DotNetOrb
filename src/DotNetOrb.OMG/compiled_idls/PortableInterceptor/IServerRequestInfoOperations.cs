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
	public interface IServerRequestInfoOperations : PortableInterceptor.IRequestInfoOperations
	{
		[IdlName("sending_exception")]
		public CORBA.Any SendingException 
		{
			get;
		}
		[IdlName("server_id")]
		[WideChar(false)]
		public string ServerId 
		{
			get;
		}
		[IdlName("orb_id")]
		[WideChar(false)]
		public string OrbId 
		{
			get;
		}
		[IdlName("adapter_name")]
		public string[] AdapterName 
		{
			get;
		}
		[IdlName("object_id")]
		public byte[] ObjectId 
		{
			get;
		}
		[IdlName("adapter_id")]
		public byte[] AdapterId 
		{
			get;
		}
		[IdlName("target_most_derived_interface")]
		[WideChar(false)]
		public string TargetMostDerivedInterface 
		{
			get;
		}
		[IdlName("get_server_policy")]
		public CORBA.IPolicy GetServerPolicy(uint type);
		[IdlName("set_slot")]
		[ThrowsIdlException(typeof(PortableInterceptor.InvalidSlot))]
		public void SetSlot(uint id, CORBA.Any data);
		[IdlName("target_is_a")]
		public bool TargetIsA([WideChar(false)] string id);
		[IdlName("add_reply_service_context")]
		public void AddReplyServiceContext(IOP.ServiceContext serviceContext, bool replace);
	}
}

