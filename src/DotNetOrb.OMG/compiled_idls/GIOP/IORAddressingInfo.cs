/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace GIOP
{
	[RepositoryID("IDL:GIOP/IORAddressingInfo:1.0")]
	[Helper(typeof(IORAddressingInfoHelper))]
	public partial class IORAddressingInfo: CORBA.IIDLEntity, IEquatable<GIOP.IORAddressingInfo>
	{
		[IdlName("IORAddressingInfo")]
		public uint SelectedProfileIndex { get; set; }
		[IdlName("IORAddressingInfo")]
		public IOP.IOR Ior { get; set; }

		public IORAddressingInfo()
		{
		}

		public IORAddressingInfo(IORAddressingInfo other)
		{
			SelectedProfileIndex = other.SelectedProfileIndex;
			Ior = other.Ior;
		}

		public IORAddressingInfo(uint selectedProfileIndex, IOP.IOR ior)
		{
			this.SelectedProfileIndex = selectedProfileIndex;
			this.Ior = ior;
		}

		public bool Equals(GIOP.IORAddressingInfo? other)
		{
			if (other == null) return false;
			if (!SelectedProfileIndex.Equals(other.SelectedProfileIndex)) return false;
			if (!Ior.Equals(other.Ior)) return false;
			return true;
		}
	}

}
