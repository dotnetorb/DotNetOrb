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

	public class ObjectGroupManagerPOATie: ObjectGroupManagerPOA
	{
		public IObjectGroupManagerOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public ObjectGroupManagerPOATie(IObjectGroupManagerOperations d)
		{
			_OperationsDelegate = d;
		}

		public ObjectGroupManagerPOATie(IObjectGroupManagerOperations d, PortableServer.POA poa)
		{
			_OperationsDelegate = d;
			_poa = poa;
		}

		public override PortableServer.IPOA _DefaultPOA()
		{
			if (_poa != null)
			{
				return _poa;
			}
			return base._DefaultPOA();
		}

		public override PortableGroup.IObjectGroupManager _This()
		{
			return PortableGroup.ObjectGroupManagerHelper.Narrow(_ThisObject());
		}

		public override PortableGroup.IObjectGroupManager _This(CORBA.ORB orb)
		{
			return PortableGroup.ObjectGroupManagerHelper.Narrow(_ThisObject(orb));
		}

		[IdlName("create_member")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		[ThrowsIdlException(typeof(PortableGroup.MemberAlreadyPresent))]
		[ThrowsIdlException(typeof(PortableGroup.NoFactory))]
		[ThrowsIdlException(typeof(PortableGroup.ObjectNotCreated))]
		[ThrowsIdlException(typeof(PortableGroup.InvalidCriteria))]
		[ThrowsIdlException(typeof(PortableGroup.CannotMeetCriteria))]
		public override CORBA.IObject CreateMember(CORBA.IObject objectGroup, CosNaming.NameComponent[] theLocation, [WideChar(false)] string typeId, PortableGroup.Property[] theCriteria)
		{
			return _OperationsDelegate.CreateMember(objectGroup, theLocation, typeId, theCriteria);
		}
		[IdlName("add_member")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		[ThrowsIdlException(typeof(PortableGroup.MemberAlreadyPresent))]
		[ThrowsIdlException(typeof(PortableGroup.ObjectNotAdded))]
		public override CORBA.IObject AddMember(CORBA.IObject objectGroup, CosNaming.NameComponent[] theLocation, CORBA.IObject member)
		{
			return _OperationsDelegate.AddMember(objectGroup, theLocation, member);
		}
		[IdlName("remove_member")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		[ThrowsIdlException(typeof(PortableGroup.MemberNotFound))]
		public override CORBA.IObject RemoveMember(CORBA.IObject objectGroup, CosNaming.NameComponent[] theLocation)
		{
			return _OperationsDelegate.RemoveMember(objectGroup, theLocation);
		}
		[IdlName("locations_of_members")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		public override CosNaming.NameComponent[][] LocationsOfMembers(CORBA.IObject objectGroup)
		{
			return _OperationsDelegate.LocationsOfMembers(objectGroup);
		}
		[IdlName("get_object_group_id")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		public override ulong GetObjectGroupId(CORBA.IObject objectGroup)
		{
			return _OperationsDelegate.GetObjectGroupId(objectGroup);
		}
		[IdlName("get_object_group_ref")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		public override CORBA.IObject GetObjectGroupRef(CORBA.IObject objectGroup)
		{
			return _OperationsDelegate.GetObjectGroupRef(objectGroup);
		}
		[IdlName("get_member_ref")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		[ThrowsIdlException(typeof(PortableGroup.MemberNotFound))]
		public override CORBA.IObject GetMemberRef(CORBA.IObject objectGroup, CosNaming.NameComponent[] loc)
		{
			return _OperationsDelegate.GetMemberRef(objectGroup, loc);
		}
	}
}