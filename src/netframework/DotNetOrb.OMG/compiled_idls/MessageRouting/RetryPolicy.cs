/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:36
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace MessageRouting
{
	[IdlName("RetryPolicy")]
	[RepositoryID("IDL:MessageRouting/RetryPolicy:1.0")]
	[Helper(typeof(RetryPolicyHelper))]
	public abstract class RetryPolicy : CORBA.Object, CORBA.IPolicy, CORBA.IStreamableValue
	{
		public virtual string[] _TruncatableIds { get => new[] {"IDL:MessageRouting/RetryPolicy:1.0"}; } 

		public virtual CORBA.TypeCode _Type { get => MessageRouting.RetryPolicyHelper.Type(); }



		[IdlName("policy_type")]
		public abstract uint PolicyType 
		{
			get;
		}
		[IdlName("copy")]
		public abstract CORBA.IPolicy Copy();
		[IdlName("destroy")]
		public abstract void Destroy();

		public virtual void _Write(CORBA.IOutputStream outputStream)
		{
		}

		public virtual void _Read(CORBA.IInputStream inputStream)
		{
		}
	}
}

