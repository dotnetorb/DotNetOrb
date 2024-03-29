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
	public interface IInterfaceDefOperations : CORBA.IContainerOperations, CORBA.IContainedOperations, CORBA.IIDLTypeOperations
	{
		[IdlName("base_interfaces")]
		public CORBA.IInterfaceDef[] BaseInterfaces 
		{
			get;

			set;
		}
		[IdlName("is_abstract")]
		public bool IsAbstract 
		{
			get;

			set;
		}
		[IdlName("is_a")]
		public bool IsA([WideChar(false)] string interfaceId);
		[IdlName("describe_interface")]
		public CORBA.InterfaceDef.FullInterfaceDescription DescribeInterface();
		[IdlName("create_attribute")]
		public CORBA.IAttributeDef CreateAttribute([WideChar(false)] string id, [WideChar(false)] string name, [WideChar(false)] string version, CORBA.IIDLType type, CORBA.AttributeMode mode);
		[IdlName("create_operation")]
		public CORBA.IOperationDef CreateOperation([WideChar(false)] string id, [WideChar(false)] string name, [WideChar(false)] string version, CORBA.IIDLType result, CORBA.OperationMode mode, CORBA.ParameterDescription[] @params, CORBA.IExceptionDef[] exceptions, string[] contexts);
	}
}

