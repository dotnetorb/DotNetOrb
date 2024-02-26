/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace CONV_FRAME
{
	[RepositoryID("IDL:CONV_FRAME/CodeSetComponent:1.0")]
	[Helper(typeof(CodeSetComponentHelper))]
	public partial class CodeSetComponent: CORBA.IIDLEntity, IEquatable<CONV_FRAME.CodeSetComponent>
	{
		[IdlName("CodeSetComponent")]
		public uint NativeCodeSet { get; set; }
		[IdlName("CodeSetComponent")]
		public uint[] ConversionCodeSets { get; set; }

		public CodeSetComponent()
		{
		}

		public CodeSetComponent(CodeSetComponent other)
		{
			NativeCodeSet = other.NativeCodeSet;
			ConversionCodeSets = other.ConversionCodeSets;
		}

		public CodeSetComponent(uint nativeCodeSet, uint[] conversionCodeSets)
		{
			this.NativeCodeSet = nativeCodeSet;
			this.ConversionCodeSets = conversionCodeSets;
		}

		public bool Equals(CONV_FRAME.CodeSetComponent? other)
		{
			if (other == null) return false;
			if (!NativeCodeSet.Equals(other.NativeCodeSet)) return false;
			if (!ConversionCodeSets.SequenceEqual(other.ConversionCodeSets)) return false;
			return true;
		}
	}

}
