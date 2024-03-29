/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:34
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace Messaging
{
	[RepositoryID("IDL:Messaging/RoutingTypeRange:1.0")]
	[Helper(typeof(RoutingTypeRangeHelper))]
	public partial class RoutingTypeRange: CORBA.IIDLEntity, IEquatable<Messaging.RoutingTypeRange>
	{
		[IdlName("RoutingTypeRange")]
		public short Min { get; set; }
		[IdlName("RoutingTypeRange")]
		public short Max { get; set; }

		public RoutingTypeRange()
		{
		}

		public RoutingTypeRange(RoutingTypeRange other)
		{
			Min = other.Min;
			Max = other.Max;
		}

		public RoutingTypeRange(short min, short max)
		{
			this.Min = min;
			this.Max = max;
		}

		public bool Equals(Messaging.RoutingTypeRange? other)
		{
			if (other == null) return false;
			if (!Min.Equals(other.Min)) return false;
			if (!Max.Equals(other.Max)) return false;
			return true;
		}
	}

}
