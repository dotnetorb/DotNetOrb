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
	public interface IExtValueDefOperations : CORBA.IValueDefOperations
	{
		[IdlName("ext_initializers")]
		public CORBA.ExtInitializer[] ExtInitializers 
		{
			get;

			set;
		}
		[IdlName("describe_ext_value")]
		public CORBA.ExtValueDef.ExtFullValueDescription DescribeExtValue();
		[IdlName("create_ext_attribute")]
		public CORBA.IExtAttributeDef CreateExtAttribute([WideChar(false)] string id, [WideChar(false)] string name, [WideChar(false)] string version, CORBA.IIDLType type, CORBA.AttributeMode mode, CORBA.IExceptionDef[] getExceptions, CORBA.IExceptionDef[] setExceptions);
	}
}

