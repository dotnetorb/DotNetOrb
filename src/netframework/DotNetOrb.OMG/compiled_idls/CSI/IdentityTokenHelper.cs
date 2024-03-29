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
	public static class IdentityTokenHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(IdentityTokenHelper))
				{
					if (type == null)
					{
						var members = new List<CORBA.UnionMember>();
						CORBA.Any anyLabel;
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertULong(0);
						members.Add(new CORBA.UnionMember("absent", anyLabel, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 8), null));
						type = CORBA.ORB.Init().CreateUnionTc(CSI.IdentityTokenHelper.Id(), "IdentityToken", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), members.ToArray());
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertULong(1);
						members.Add(new CORBA.UnionMember("anonymous", anyLabel, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 8), null));
						type = CORBA.ORB.Init().CreateUnionTc(CSI.IdentityTokenHelper.Id(), "IdentityToken", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), members.ToArray());
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertULong(2);
						members.Add(new CORBA.UnionMember("principal_name", anyLabel, CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null));
						type = CORBA.ORB.Init().CreateUnionTc(CSI.IdentityTokenHelper.Id(), "IdentityToken", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), members.ToArray());
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertULong(4);
						members.Add(new CORBA.UnionMember("certificate_chain", anyLabel, CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null));
						type = CORBA.ORB.Init().CreateUnionTc(CSI.IdentityTokenHelper.Id(), "IdentityToken", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), members.ToArray());
						anyLabel = CORBA.ORB.Init().CreateAny();
						anyLabel.InsertULong(8);
						members.Add(new CORBA.UnionMember("dn", anyLabel, CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null));
						type = CORBA.ORB.Init().CreateUnionTc(CSI.IdentityTokenHelper.Id(), "IdentityToken", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), members.ToArray());
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CSI.IdentityToken value)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), value);
		}

		public static CSI.IdentityToken Extract(CORBA.Any any)
		{
			var inputStream = any.CreateInputStream();
			try
			{
				return Read(inputStream);
			}
			finally
			{
				inputStream.Close();
			}
		}

		public static string Id()
		{
		    return "IDL:CSI/IdentityToken:1.0";
		}

		public static CSI.IdentityToken Read(CORBA.IInputStream inputStream)
		{
			var result = new CSI.IdentityToken();
			uint disc;
			disc = inputStream.ReadULong();
			switch (disc)
			{
				case 0:
				{
					result.Absent = inputStream.ReadBoolean();
					break;
				}
				case 1:
				{
					result.Anonymous = inputStream.ReadBoolean();
					break;
				}
				case 2:
				{
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						var _array = new byte[_capacity0];
						inputStream.ReadOctetArray(ref _array, 0, _capacity0);
						result.PrincipalName = _array;
					}
					break;
				}
				case 4:
				{
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						var _array = new byte[_capacity0];
						inputStream.ReadOctetArray(ref _array, 0, _capacity0);
						result.CertificateChain = _array;
					}
					break;
				}
				case 8:
				{
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						var _array = new byte[_capacity0];
						inputStream.ReadOctetArray(ref _array, 0, _capacity0);
						result.Dn = _array;
					}
					break;
				}
				default:
				{
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						var _array = new byte[_capacity0];
						inputStream.ReadOctetArray(ref _array, 0, _capacity0);
						result.Id = _array;
					}
					break;
				}
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CSI.IdentityToken value)
		{
			outputStream.WriteULong(value._Discriminator);
			switch (value._Discriminator)
			{
				case 0:
				{
					outputStream.WriteBoolean(value.Absent);
					break;
				}
				case 1:
				{
					outputStream.WriteBoolean(value.Anonymous);
					break;
				}
				case 2:
				{
					{
						outputStream.WriteLong(value.PrincipalName.Length);
						outputStream.WriteOctetArray(value.PrincipalName, 0, value.PrincipalName.Length);
					}
					break;
				}
				case 4:
				{
					{
						outputStream.WriteLong(value.CertificateChain.Length);
						outputStream.WriteOctetArray(value.CertificateChain, 0, value.CertificateChain.Length);
					}
					break;
				}
				case 8:
				{
					{
						outputStream.WriteLong(value.Dn.Length);
						outputStream.WriteOctetArray(value.Dn, 0, value.Dn.Length);
					}
					break;
				}
				default:
				{
					{
						outputStream.WriteLong(value.Id.Length);
						outputStream.WriteOctetArray(value.Id, 0, value.Id.Length);
					}
					break;
				}
			}
		}

	}
}
