/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:27
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{

	public class PrimitiveDefPOATie: PrimitiveDefPOA
	{
		public IPrimitiveDefOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public PrimitiveDefPOATie(IPrimitiveDefOperations d)
		{
			_OperationsDelegate = d;
		}

		public PrimitiveDefPOATie(IPrimitiveDefOperations d, PortableServer.POA poa)
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

		public override CORBA.IPrimitiveDef _This()
		{
			return CORBA.PrimitiveDefHelper.Narrow(_ThisObject());
		}

		public override CORBA.IPrimitiveDef _This(CORBA.ORB orb)
		{
			return CORBA.PrimitiveDefHelper.Narrow(_ThisObject(orb));
		}

		public override CORBA.DefinitionKind DefKind 
		{
			get
			{
				return _OperationsDelegate.DefKind;
			}
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
		public override CORBA.TypeCode Type 
		{
			get
			{
				return _OperationsDelegate.Type;
			}
		}
		public override CORBA.PrimitiveKind Kind 
		{
			get
			{
				return _OperationsDelegate.Kind;
			}
		}
	}
}
