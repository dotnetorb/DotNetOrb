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

	public class IRObjectPOATie: IRObjectPOA
	{
		public IIRObjectOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public IRObjectPOATie(IIRObjectOperations d)
		{
			_OperationsDelegate = d;
		}

		public IRObjectPOATie(IIRObjectOperations d, PortableServer.POA poa)
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

		public override CORBA.IIRObject _This()
		{
			return CORBA.IRObjectHelper.Narrow(_ThisObject());
		}

		public override CORBA.IIRObject _This(CORBA.ORB orb)
		{
			return CORBA.IRObjectHelper.Narrow(_ThisObject(orb));
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
	}
}