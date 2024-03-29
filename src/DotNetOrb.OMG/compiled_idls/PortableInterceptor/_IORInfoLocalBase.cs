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
	public abstract class _IORInfoLocalBase: CORBA.LocalObject, IIORInfo
	{
		private string[] _ids = {"IDL:PortableInterceptor/IORInfo:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		[IdlName("get_effective_policy")]
		public abstract CORBA.IPolicy GetEffectivePolicy(uint type);
		[IdlName("add_ior_component")]
		public abstract void AddIorComponent(IOP.TaggedComponent aComponent);
		[IdlName("add_ior_component_to_profile")]
		public abstract void AddIorComponentToProfile(IOP.TaggedComponent aComponent, uint profileId);
	}

}
