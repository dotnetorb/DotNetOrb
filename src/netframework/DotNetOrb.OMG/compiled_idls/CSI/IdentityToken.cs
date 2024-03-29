/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:29
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace CSI
{
	[IdlName("IdentityToken")]
	[RepositoryID("IDL:CSI/IdentityToken:1.0")]
	[Helper(typeof(IdentityTokenHelper))]
	public partial class IdentityToken: CORBA.IIDLEntity, IEquatable<IdentityToken>
	{
		public IdentityToken()
		{
		}

		public IdentityToken(IdentityToken other)
		{
			_Discriminator = other._Discriminator;
			Absent = other.Absent;
			Anonymous = other.Anonymous;
			PrincipalName = other.PrincipalName;
			CertificateChain = other.CertificateChain;
			Dn = other.Dn;
			Id = other.Id;
		}

		public bool Equals(IdentityToken? other)
		{
			if (other == null) return false;
			if (_Discriminator != other._Discriminator) return false;
			switch (_Discriminator)
			{
				case 0:
					if (!Absent.Equals(other.Absent)) return false;
					break;
				case 1:
					if (!Anonymous.Equals(other.Anonymous)) return false;
					break;
				case 2:
					if (!PrincipalName.SequenceEqual(other.PrincipalName)) return false;
					break;
				case 4:
					if (!CertificateChain.SequenceEqual(other.CertificateChain)) return false;
					break;
				case 8:
					if (!Dn.SequenceEqual(other.Dn)) return false;
					break;
				default:
					if (!Id.SequenceEqual(other.Id)) return false;
					break;
			}
			return true;
		}

		public uint _Discriminator { get; private set; }

		private bool _absent;
		public bool Absent
		{
			get
			{
				if (_Discriminator != 0) throw new System.InvalidOperationException();
				return _absent;
			}
			set
			{
				_Discriminator = 0;
				_absent = value;
			}
		}
		private bool _anonymous;
		public bool Anonymous
		{
			get
			{
				if (_Discriminator != 1) throw new System.InvalidOperationException();
				return _anonymous;
			}
			set
			{
				_Discriminator = 1;
				_anonymous = value;
			}
		}
		private byte[] _principalName;
		public byte[] PrincipalName
		{
			get
			{
				if (_Discriminator != 2) throw new System.InvalidOperationException();
				return _principalName;
			}
			set
			{
				_Discriminator = 2;
				_principalName = value;
			}
		}
		private byte[] _certificateChain;
		public byte[] CertificateChain
		{
			get
			{
				if (_Discriminator != 4) throw new System.InvalidOperationException();
				return _certificateChain;
			}
			set
			{
				_Discriminator = 4;
				_certificateChain = value;
			}
		}
		private byte[] _dn;
		public byte[] Dn
		{
			get
			{
				if (_Discriminator != 8) throw new System.InvalidOperationException();
				return _dn;
			}
			set
			{
				_Discriminator = 8;
				_dn = value;
			}
		}
		private byte[] _id;
		public byte[] Id
		{
			get
			{
				if (_Discriminator != (uint) 0) throw new System.InvalidOperationException();
				return _id;
			}
			set
			{
				_Discriminator = (uint) 0;
				_id = value;
			}
		}
	}

}
