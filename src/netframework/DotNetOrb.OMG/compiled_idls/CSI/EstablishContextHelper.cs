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
	public static class EstablishContextHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(EstablishContextHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(CSI.EstablishContextHelper.Id(), "EstablishContext", new CORBA.StructMember[] {new CORBA.StructMember("client_context_id", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 24), null), new CORBA.StructMember("authorization_token", CORBA.ORB.Init().CreateSequenceTc(0, CSI.AuthorizationElementHelper.Type()), null), new CORBA.StructMember("identity_token", CSI.IdentityTokenHelper.Type(), null), new CORBA.StructMember("client_authentication_token", CORBA.ORB.Init().CreateSequenceTc(0, CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 10)), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, CSI.EstablishContext s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static CSI.EstablishContext Extract(CORBA.Any any)
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
			return "IDL:CSI/EstablishContext:1.0";
		}

		public static CSI.EstablishContext Read(CORBA.IInputStream inputStream)
		{
			var result = new CSI.EstablishContext();
			result.ClientContextId = inputStream.ReadULongLong();
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				result.AuthorizationToken = new CSI.AuthorizationElement[_capacity0];
				for (int i0 = 0; i0 < _capacity0; i0++)
				{
					CSI.AuthorizationElement _item0;
					_item0 = CSI.AuthorizationElementHelper.Read(inputStream);
					result.AuthorizationToken[i0] = _item0;
				}
			}
			result.IdentityToken = CSI.IdentityTokenHelper.Read(inputStream);
			{
				var _capacity0 = inputStream.ReadLong();
				if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
				{
					throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
				}
				var _array = new byte[_capacity0];
				inputStream.ReadOctetArray(ref _array, 0, _capacity0);
				result.ClientAuthenticationToken = _array;
			}
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, CSI.EstablishContext s)
		{
			outputStream.WriteULongLong(s.ClientContextId);
			{
				outputStream.WriteLong(s.AuthorizationToken.Length);
				for (int i0 = 0; i0 < s.AuthorizationToken.Length; i0++)
				{
					CSI.AuthorizationElementHelper.Write(outputStream, s.AuthorizationToken[i0]);
				}
			}
			CSI.IdentityTokenHelper.Write(outputStream, s.IdentityToken);
			{
				outputStream.WriteLong(s.ClientAuthenticationToken.Length);
				outputStream.WriteOctetArray(s.ClientAuthenticationToken, 0, s.ClientAuthenticationToken.Length);
			}
		}

	}
}
