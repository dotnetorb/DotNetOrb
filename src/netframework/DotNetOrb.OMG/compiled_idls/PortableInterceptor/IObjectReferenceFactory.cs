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
	[RepositoryID("IDL:PortableInterceptor/ObjectReferenceFactory:1.0")]
	[Helper(typeof(ObjectReferenceFactoryHelper))]
	public interface IObjectReferenceFactory : CORBA.IValueBase
	{
		[IdlName("make_object")]
		public CORBA.IObject MakeObject([WideChar(false)] string repositoryId, byte[] id);
	}
}

