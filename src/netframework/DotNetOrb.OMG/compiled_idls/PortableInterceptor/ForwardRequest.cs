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
	[IdlName("ForwardRequest")]
	[RepositoryID("IDL:PortableInterceptor/ForwardRequest:1.0")]
	[Helper(typeof(ForwardRequestHelper))]
	public partial class ForwardRequest: CORBA.UserException, CORBA.IIDLEntity, IEquatable<PortableInterceptor.ForwardRequest>
	{
		public ForwardRequest()
		{
		}

		public ForwardRequest(string _msg): base(_msg)
		{
		}

		public ForwardRequest(ForwardRequest other)
		{
			Forward = other.Forward;
		}

		public ForwardRequest(CORBA.IObject forward, string _msg = ""): base(_msg)
		{
			this.Forward = forward;
		}

		public bool Equals(PortableInterceptor.ForwardRequest? other)
		{
			if (other == null) return false;
			if (!Forward.Equals(other.Forward)) return false;
			return true;
		}
		[IdlName("forward")]
		public CORBA.IObject Forward { get; set; }
	}

}
