/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{
	public interface IAdapterActivatorOperations
	{
		[IdlName("unknown_adapter")]
		public bool UnknownAdapter(PortableServer.IPOA parent, [WideChar(false)] string name);
	}
}

