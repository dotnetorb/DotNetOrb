/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:26
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public interface IPollableSetOperations
	{
		[IdlName("create_dii_pollable")]
		public CORBA.IDIIPollable CreateDiiPollable();
		[IdlName("add_pollable")]
		public void AddPollable(CORBA.IPollable potential);
		[IdlName("get_ready_pollable")]
		[ThrowsIdlException(typeof(CORBA.PollableSet.NoPossiblePollable))]
		public CORBA.IPollable GetReadyPollable(uint timeout);
		[IdlName("remove")]
		[ThrowsIdlException(typeof(CORBA.PollableSet.UnknownPollable))]
		public void Remove(CORBA.IPollable potential);
		[IdlName("number_left")]
		public ushort NumberLeft();
	}
}

