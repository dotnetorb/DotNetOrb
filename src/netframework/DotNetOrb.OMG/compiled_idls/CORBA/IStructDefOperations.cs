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
	public interface IStructDefOperations : CORBA.ITypedefDefOperations, CORBA.IContainerOperations
	{
		[IdlName("members")]
		public CORBA.StructMember[] Members 
		{
			get;

			set;
		}
	}
}

