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
	public interface IProcessingModePolicyOperations : CORBA.IPolicyOperations
	{
		[IdlName("processing_mode")]
		public short ProcessingMode 
		{
			get;
		}
	}
}
