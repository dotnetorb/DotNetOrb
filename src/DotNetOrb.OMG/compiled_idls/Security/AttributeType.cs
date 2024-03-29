/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace Security
{
	[RepositoryID("IDL:omg.org/Security/AttributeType:1.0")]
	[Helper(typeof(AttributeTypeHelper))]
	public partial class AttributeType: CORBA.IIDLEntity, IEquatable<Security.AttributeType>
	{
		[IdlName("AttributeType")]
		public Security.ExtensibleFamily AttributeFamily { get; set; }
		[IdlName("AttributeType")]
		public uint _AttributeType { get; set; }

		public AttributeType()
		{
		}

		public AttributeType(AttributeType other)
		{
			AttributeFamily = other.AttributeFamily;
			_AttributeType = other._AttributeType;
		}

		public AttributeType(Security.ExtensibleFamily attributeFamily, uint attributeType)
		{
			this.AttributeFamily = attributeFamily;
			this._AttributeType = attributeType;
		}

		public bool Equals(Security.AttributeType? other)
		{
			if (other == null) return false;
			if (!AttributeFamily.Equals(other.AttributeFamily)) return false;
			if (!_AttributeType.Equals(other._AttributeType)) return false;
			return true;
		}
	}

}
