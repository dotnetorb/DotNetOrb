/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{
	public interface IGenericFactoryOperations
	{
		[IdlName("create_object")]
		[ThrowsIdlException(typeof(PortableGroup.NoFactory))]
		[ThrowsIdlException(typeof(PortableGroup.ObjectNotCreated))]
		[ThrowsIdlException(typeof(PortableGroup.InvalidCriteria))]
		[ThrowsIdlException(typeof(PortableGroup.InvalidProperty))]
		[ThrowsIdlException(typeof(PortableGroup.CannotMeetCriteria))]
		public CORBA.IObject CreateObject([WideChar(false)] string typeId, PortableGroup.Property[] theCriteria, out CORBA.Any factoryCreationId);
		[IdlName("delete_object")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectNotFound))]
		public void DeleteObject(CORBA.Any factoryCreationId);
	}
}

