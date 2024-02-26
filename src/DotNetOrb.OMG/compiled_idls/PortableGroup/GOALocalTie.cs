/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:31
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{

	public class GOALocalTie: _GOALocalBase
	{
		public IGOAOperations _OperationsDelegate { get; set; }

		public GOALocalTie(IGOAOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("create_POA")]
		[ThrowsIdlException(typeof(PortableServer.POA.AdapterAlreadyExists))]
		[ThrowsIdlException(typeof(PortableServer.POA.InvalidPolicy))]
		public override PortableServer.IPOA CreatePoa([WideChar(false)] string adapterName, PortableServer.IPOAManager aPOAManager, CORBA.IPolicy[] policies)
		{
			return _OperationsDelegate.CreatePoa(adapterName, aPOAManager, policies);
		}
		[IdlName("find_POA")]
		[ThrowsIdlException(typeof(PortableServer.POA.AdapterNonExistent))]
		public override PortableServer.IPOA FindPoa([WideChar(false)] string adapterName, bool activateIt)
		{
			return _OperationsDelegate.FindPoa(adapterName, activateIt);
		}
		[IdlName("destroy")]
		public override void Destroy(bool etherealizeObjects, bool waitForCompletion)
		{
			_OperationsDelegate.Destroy(etherealizeObjects, waitForCompletion);
		}
		[IdlName("create_thread_policy")]
		public override PortableServer.IThreadPolicy CreateThreadPolicy(PortableServer.ThreadPolicyValue value)
		{
			return _OperationsDelegate.CreateThreadPolicy(value);
		}
		[IdlName("create_lifespan_policy")]
		public override PortableServer.ILifespanPolicy CreateLifespanPolicy(PortableServer.LifespanPolicyValue value)
		{
			return _OperationsDelegate.CreateLifespanPolicy(value);
		}
		[IdlName("create_id_uniqueness_policy")]
		public override PortableServer.IIdUniquenessPolicy CreateIdUniquenessPolicy(PortableServer.IdUniquenessPolicyValue value)
		{
			return _OperationsDelegate.CreateIdUniquenessPolicy(value);
		}
		[IdlName("create_id_assignment_policy")]
		public override PortableServer.IIdAssignmentPolicy CreateIdAssignmentPolicy(PortableServer.IdAssignmentPolicyValue value)
		{
			return _OperationsDelegate.CreateIdAssignmentPolicy(value);
		}
		[IdlName("create_implicit_activation_policy")]
		public override PortableServer.IImplicitActivationPolicy CreateImplicitActivationPolicy(PortableServer.ImplicitActivationPolicyValue value)
		{
			return _OperationsDelegate.CreateImplicitActivationPolicy(value);
		}
		[IdlName("create_servant_retention_policy")]
		public override PortableServer.IServantRetentionPolicy CreateServantRetentionPolicy(PortableServer.ServantRetentionPolicyValue value)
		{
			return _OperationsDelegate.CreateServantRetentionPolicy(value);
		}
		[IdlName("create_request_processing_policy")]
		public override PortableServer.IRequestProcessingPolicy CreateRequestProcessingPolicy(PortableServer.RequestProcessingPolicyValue value)
		{
			return _OperationsDelegate.CreateRequestProcessingPolicy(value);
		}
		[WideChar(false)]
		public override string TheName 
		{
			get
			{
				return _OperationsDelegate.TheName;
			}
		}
		public override PortableServer.IPOA TheParent 
		{
			get
			{
				return _OperationsDelegate.TheParent;
			}
		}
		public override PortableServer.IPOA[] TheChildren 
		{
			get
			{
				return _OperationsDelegate.TheChildren;
			}
		}
		public override PortableServer.IPOAManager ThePOAManager 
		{
			get
			{
				return _OperationsDelegate.ThePOAManager;
			}
		}
		public override PortableServer.IAdapterActivator TheActivator 
		{
			get
			{
				return _OperationsDelegate.TheActivator;
			}

			set
			{
				_OperationsDelegate.TheActivator = value;
			}
		}
		[IdlName("get_servant_manager")]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override PortableServer.IServantManager GetServantManager()
		{
			return _OperationsDelegate.GetServantManager();
		}
		[IdlName("set_servant_manager")]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override void SetServantManager(PortableServer.IServantManager imgr)
		{
			_OperationsDelegate.SetServantManager(imgr);
		}
		[IdlName("get_servant")]
		[ThrowsIdlException(typeof(PortableServer.POA.NoServant))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override PortableServer.Servant GetServant()
		{
			return _OperationsDelegate.GetServant();
		}
		[IdlName("set_servant")]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override void SetServant(PortableServer.Servant pServant)
		{
			_OperationsDelegate.SetServant(pServant);
		}
		[IdlName("activate_object")]
		[ThrowsIdlException(typeof(PortableServer.POA.ServantAlreadyActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override byte[] ActivateObject(PortableServer.Servant pServant)
		{
			return _OperationsDelegate.ActivateObject(pServant);
		}
		[IdlName("activate_object_with_id")]
		[ThrowsIdlException(typeof(PortableServer.POA.ServantAlreadyActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.ObjectAlreadyActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override void ActivateObjectWithId(byte[] id, PortableServer.Servant pServant)
		{
			_OperationsDelegate.ActivateObjectWithId(id, pServant);
		}
		[IdlName("deactivate_object")]
		[ThrowsIdlException(typeof(PortableServer.POA.ObjectNotActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override void DeactivateObject(byte[] oid)
		{
			_OperationsDelegate.DeactivateObject(oid);
		}
		[IdlName("create_reference")]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override CORBA.IObject CreateReference([WideChar(false)] string intf)
		{
			return _OperationsDelegate.CreateReference(intf);
		}
		[IdlName("create_reference_with_id")]
		public override CORBA.IObject CreateReferenceWithId(byte[] oid, [WideChar(false)] string intf)
		{
			return _OperationsDelegate.CreateReferenceWithId(oid, intf);
		}
		[IdlName("servant_to_id")]
		[ThrowsIdlException(typeof(PortableServer.POA.ServantNotActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override byte[] ServantToId(PortableServer.Servant pServant)
		{
			return _OperationsDelegate.ServantToId(pServant);
		}
		[IdlName("servant_to_reference")]
		[ThrowsIdlException(typeof(PortableServer.POA.ServantNotActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override CORBA.IObject ServantToReference(PortableServer.Servant pServant)
		{
			return _OperationsDelegate.ServantToReference(pServant);
		}
		[IdlName("reference_to_servant")]
		[ThrowsIdlException(typeof(PortableServer.POA.ObjectNotActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongAdapter))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override PortableServer.Servant ReferenceToServant(CORBA.IObject reference)
		{
			return _OperationsDelegate.ReferenceToServant(reference);
		}
		[IdlName("reference_to_id")]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongAdapter))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override byte[] ReferenceToId(CORBA.IObject reference)
		{
			return _OperationsDelegate.ReferenceToId(reference);
		}
		[IdlName("id_to_servant")]
		[ThrowsIdlException(typeof(PortableServer.POA.ObjectNotActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override PortableServer.Servant IdToServant(byte[] oid)
		{
			return _OperationsDelegate.IdToServant(oid);
		}
		[IdlName("id_to_reference")]
		[ThrowsIdlException(typeof(PortableServer.POA.ObjectNotActive))]
		[ThrowsIdlException(typeof(PortableServer.POA.WrongPolicy))]
		public override CORBA.IObject IdToReference(byte[] oid)
		{
			return _OperationsDelegate.IdToReference(oid);
		}
		public override byte[] Id 
		{
			get
			{
				return _OperationsDelegate.Id;
			}
		}
		public override PortableServer.IPOAManagerFactory ThePOAManagerFactory 
		{
			get
			{
				return _OperationsDelegate.ThePOAManagerFactory;
			}
		}
		[IdlName("create_id_for_reference")]
		[ThrowsIdlException(typeof(PortableGroup.GOA.NotAGroupObject))]
		public override byte[] CreateIdForReference(CORBA.IObject theRef)
		{
			return _OperationsDelegate.CreateIdForReference(theRef);
		}
		[IdlName("reference_to_ids")]
		[ThrowsIdlException(typeof(PortableGroup.GOA.NotAGroupObject))]
		public override byte[][] ReferenceToIds(CORBA.IObject theRef)
		{
			return _OperationsDelegate.ReferenceToIds(theRef);
		}
		[IdlName("associate_reference_with_id")]
		[ThrowsIdlException(typeof(PortableGroup.GOA.NotAGroupObject))]
		public override void AssociateReferenceWithId(CORBA.IObject @ref, byte[] oid)
		{
			_OperationsDelegate.AssociateReferenceWithId(@ref, oid);
		}
		[IdlName("disassociate_reference_with_id")]
		[ThrowsIdlException(typeof(PortableGroup.GOA.NotAGroupObject))]
		public override void DisassociateReferenceWithId(CORBA.IObject @ref, byte[] oid)
		{
			_OperationsDelegate.DisassociateReferenceWithId(@ref, oid);
		}
	}
}