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

	public class PropertyManagerPOATie: PropertyManagerPOA
	{
		public IPropertyManagerOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public PropertyManagerPOATie(IPropertyManagerOperations d)
		{
			_OperationsDelegate = d;
		}

		public PropertyManagerPOATie(IPropertyManagerOperations d, PortableServer.POA poa)
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

		public override PortableGroup.IPropertyManager _This()
		{
			return PortableGroup.PropertyManagerHelper.Narrow(_ThisObject());
		}

		public override PortableGroup.IPropertyManager _This(CORBA.ORB orb)
		{
			return PortableGroup.PropertyManagerHelper.Narrow(_ThisObject(orb));
		}

		[IdlName("set_default_properties")]
		[ThrowsIdlException(typeof(PortableGroup.InvalidProperty))]
		[ThrowsIdlException(typeof(PortableGroup.UnsupportedProperty))]
		public override void SetDefaultProperties(PortableGroup.Property[] props)
		{
			_OperationsDelegate.SetDefaultProperties(props);
		}
		[IdlName("get_default_properties")]
		public override PortableGroup.Property[] GetDefaultProperties()
		{
			return _OperationsDelegate.GetDefaultProperties();
		}
		[IdlName("remove_default_properties")]
		[ThrowsIdlException(typeof(PortableGroup.InvalidProperty))]
		[ThrowsIdlException(typeof(PortableGroup.UnsupportedProperty))]
		public override void RemoveDefaultProperties(PortableGroup.Property[] props)
		{
			_OperationsDelegate.RemoveDefaultProperties(props);
		}
		[IdlName("set_type_properties")]
		[ThrowsIdlException(typeof(PortableGroup.InvalidProperty))]
		[ThrowsIdlException(typeof(PortableGroup.UnsupportedProperty))]
		public override void SetTypeProperties([WideChar(false)] string typeId, PortableGroup.Property[] overrides)
		{
			_OperationsDelegate.SetTypeProperties(typeId, overrides);
		}
		[IdlName("get_type_properties")]
		public override PortableGroup.Property[] GetTypeProperties([WideChar(false)] string typeId)
		{
			return _OperationsDelegate.GetTypeProperties(typeId);
		}
		[IdlName("remove_type_properties")]
		[ThrowsIdlException(typeof(PortableGroup.InvalidProperty))]
		[ThrowsIdlException(typeof(PortableGroup.UnsupportedProperty))]
		public override void RemoveTypeProperties([WideChar(false)] string typeId, PortableGroup.Property[] props)
		{
			_OperationsDelegate.RemoveTypeProperties(typeId, props);
		}
		[IdlName("set_properties_dynamically")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		[ThrowsIdlException(typeof(PortableGroup.InvalidProperty))]
		[ThrowsIdlException(typeof(PortableGroup.UnsupportedProperty))]
		public override void SetPropertiesDynamically(CORBA.IObject objectGroup, PortableGroup.Property[] overrides)
		{
			_OperationsDelegate.SetPropertiesDynamically(objectGroup, overrides);
		}
		[IdlName("get_properties")]
		[ThrowsIdlException(typeof(PortableGroup.ObjectGroupNotFound))]
		public override PortableGroup.Property[] GetProperties(CORBA.IObject objectGroup)
		{
			return _OperationsDelegate.GetProperties(objectGroup);
		}
	}
}