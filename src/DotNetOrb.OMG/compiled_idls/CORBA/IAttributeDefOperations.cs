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
	public interface IAttributeDefOperations : CORBA.IContainedOperations
	{
		[IdlName("type")]
		public CORBA.TypeCode Type 
		{
			get;
		}
		[IdlName("type_def")]
		public CORBA.IIDLType TypeDef 
		{
			get;

			set;
		}
		[IdlName("mode")]
		public CORBA.AttributeMode Mode 
		{
			get;

			set;
		}
	}
}

