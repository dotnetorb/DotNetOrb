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

	public class InterceptorLocalTie: _InterceptorLocalBase
	{
		public IInterceptorOperations _OperationsDelegate { get; set; }

		public InterceptorLocalTie(IInterceptorOperations d)
		{
			_OperationsDelegate = d;
		}

		[WideChar(false)]
		public override string Name 
		{
			get
			{
				return _OperationsDelegate.Name;
			}
		}
		[IdlName("destroy")]
		public override void Destroy()
		{
			_OperationsDelegate.Destroy();
		}
	}
}
