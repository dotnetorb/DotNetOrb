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
	public interface IArrayDefOperations : CORBA.IIDLTypeOperations
	{
		[IdlName("length")]
		public uint Length 
		{
			get;

			set;
		}
		[IdlName("element_type")]
		public CORBA.TypeCode ElementType 
		{
			get;
		}
		[IdlName("element_type_def")]
		public CORBA.IIDLType ElementTypeDef 
		{
			get;

			set;
		}
	}
}

