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
	public interface INamingContextExtOperations : CosNaming.INamingContextOperations
	{
		[IdlName("to_string")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		[return: WideChar(false)]
		public string ToString(CosNaming.NameComponent[] n);
		[IdlName("to_name")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		public CosNaming.NameComponent[] ToName([WideChar(false)] string sn);
		[IdlName("to_url")]
		[ThrowsIdlException(typeof(CosNaming.NamingContextExt.InvalidAddress))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		[return: WideChar(false)]
		public string ToUrl([WideChar(false)] string addr, [WideChar(false)] string sn);
		[IdlName("resolve_str")]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.NotFound))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.CannotProceed))]
		[ThrowsIdlException(typeof(CosNaming.NamingContext.InvalidName))]
		public CORBA.IObject ResolveStr([WideChar(false)] string n);
	}
}

