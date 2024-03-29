/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace RTCORBA
{

	public class CurrentLocalTie: _CurrentLocalBase
	{
		public ICurrentOperations _OperationsDelegate { get; set; }

		public CurrentLocalTie(ICurrentOperations d)
		{
			_OperationsDelegate = d;
		}

		public override short ThePriority 
		{
			get
			{
				return _OperationsDelegate.ThePriority;
			}

			set
			{
				_OperationsDelegate.ThePriority = value;
			}
		}
	}
}
