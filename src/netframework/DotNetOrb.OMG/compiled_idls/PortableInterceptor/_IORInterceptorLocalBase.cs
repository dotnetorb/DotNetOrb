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
	public abstract class _IORInterceptorLocalBase: CORBA.LocalObject, IIORInterceptor
	{
		private string[] _ids = {"IDL:PortableInterceptor/IORInterceptor:1.0","IDL:PortableInterceptor/Interceptor:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("name")]
		[WideChar(false)]
		public abstract string Name 
		{
			get;
		}
		[IdlName("destroy")]
		public abstract void Destroy();
		[IdlName("establish_components")]
		public abstract void EstablishComponents(PortableInterceptor.IIORInfo info);
	}

}
