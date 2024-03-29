/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace MessageRouting
{
	[IdlName("ResumePolicy")]
	[RepositoryID("IDL:MessageRouting/ResumePolicy:1.0")]
	[Helper(typeof(ResumePolicyHelper))]
	public abstract class ResumePolicy : CORBA.Object, CORBA.IPolicy, CORBA.IStreamableValue
	{
		public virtual string[] _TruncatableIds { get => new[] {"IDL:MessageRouting/ResumePolicy:1.0"}; } 

		public virtual CORBA.TypeCode _Type { get => MessageRouting.ResumePolicyHelper.Type(); }


		[IdlName("resume_seconds")]
		public uint ResumeSeconds { get; set; }

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
			outputStream.WriteULong(ResumeSeconds);
		}

		public virtual void _Read(CORBA.IInputStream inputStream)
		{
			ResumeSeconds = inputStream.ReadULong();
		}
	}
}

