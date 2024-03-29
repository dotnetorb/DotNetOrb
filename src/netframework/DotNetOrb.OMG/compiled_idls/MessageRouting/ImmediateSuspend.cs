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
	[IdlName("ImmediateSuspend")]
	[RepositoryID("IDL:MessageRouting/ImmediateSuspend:1.0")]
	[Helper(typeof(ImmediateSuspendHelper))]
	public abstract class ImmediateSuspend : MessageRouting.RetryPolicy, CORBA.IStreamableValue
	{
		public override string[] _TruncatableIds { get => new[] {"IDL:MessageRouting/ImmediateSuspend:1.0"}; } 

		public override CORBA.TypeCode _Type { get => MessageRouting.ImmediateSuspendHelper.Type(); }




		public override void _Write(CORBA.IOutputStream outputStream)
		{
			base._Write(outputStream);
		}

		public override void _Read(CORBA.IInputStream inputStream)
		{
			base._Read(inputStream);
		}
	}
}

