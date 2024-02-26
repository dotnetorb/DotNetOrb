/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CosNaming
{

	public class BindingIteratorPOATie: BindingIteratorPOA
	{
		public IBindingIteratorOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public BindingIteratorPOATie(IBindingIteratorOperations d)
		{
			_OperationsDelegate = d;
		}

		public BindingIteratorPOATie(IBindingIteratorOperations d, PortableServer.POA poa)
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

		public override CosNaming.IBindingIterator _This()
		{
			return CosNaming.BindingIteratorHelper.Narrow(_ThisObject());
		}

		public override CosNaming.IBindingIterator _This(CORBA.ORB orb)
		{
			return CosNaming.BindingIteratorHelper.Narrow(_ThisObject(orb));
		}

		[IdlName("next_one")]
		public override bool NextOne(out CosNaming.Binding b)
		{
			return _OperationsDelegate.NextOne(out b);
		}
		[IdlName("next_n")]
		public override bool NextN(uint howMany, out CosNaming.Binding[] bl)
		{
			return _OperationsDelegate.NextN(howMany, out bl);
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
	}
}
