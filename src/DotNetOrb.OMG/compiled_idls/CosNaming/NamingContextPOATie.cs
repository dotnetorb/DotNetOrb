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

	public class NamingContextPOATie: NamingContextPOA
	{
		public INamingContextOperations _OperationsDelegate { get; set; }
		private PortableServer.IPOA _poa;

		public NamingContextPOATie(INamingContextOperations d)
		{
			_OperationsDelegate = d;
		}

		public NamingContextPOATie(INamingContextOperations d, PortableServer.POA poa)
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

		public override CosNaming.INamingContext _This()
		{
			return CosNaming.NamingContextHelper.Narrow(_ThisObject());
		}

		public override CosNaming.INamingContext _This(CORBA.ORB orb)
		{
			return CosNaming.NamingContextHelper.Narrow(_ThisObject(orb));
		}

		[IdlName("bind")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.AlreadyBound))]
		public override void Bind(CosNaming.NameComponent[] n, CORBA.IObject obj)
		{
			_OperationsDelegate.Bind(n, obj);
		}
		[IdlName("rebind")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		public override void Rebind(CosNaming.NameComponent[] n, CORBA.IObject obj)
		{
			_OperationsDelegate.Rebind(n, obj);
		}
		[IdlName("bind_context")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.AlreadyBound))]
		public override void BindContext(CosNaming.NameComponent[] n, CosNaming.INamingContext nc)
		{
			_OperationsDelegate.BindContext(n, nc);
		}
		[IdlName("rebind_context")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		public override void RebindContext(CosNaming.NameComponent[] n, CosNaming.INamingContext nc)
		{
			_OperationsDelegate.RebindContext(n, nc);
		}
		[IdlName("resolve")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		public override CORBA.IObject Resolve(CosNaming.NameComponent[] n)
		{
			return _OperationsDelegate.Resolve(n);
		}
		[IdlName("unbind")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		public override void Unbind(CosNaming.NameComponent[] n)
		{
			_OperationsDelegate.Unbind(n);
		}
		[IdlName("new_context")]
		public override CosNaming.INamingContext NewContext()
		{
			return _OperationsDelegate.NewContext();
		}
		[IdlName("bind_new_context")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.AlreadyBound))]
		public override CosNaming.INamingContext BindNewContext(CosNaming.NameComponent[] n)
		{
			return _OperationsDelegate.BindNewContext(n);
		}
		[IdlName("destroy")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotEmpty))]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
		[IdlName("list")]
		public override void List(uint howMany, out CosNaming.Binding[] bl, out CosNaming.IBindingIterator bi)
		{
			_OperationsDelegate.List(howMany, out bl, out bi);
		}
	}
}