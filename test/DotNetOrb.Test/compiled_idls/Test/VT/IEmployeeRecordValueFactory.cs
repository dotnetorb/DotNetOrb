/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Test.VT
{
	public interface IEmployeeRecordValueFactory : CORBA.IValueFactory
	{
		[IdlName("init")]
		EmployeeRecord Init([WideChar(false)] string name, [WideChar(false)] string ssn);
	}
}

