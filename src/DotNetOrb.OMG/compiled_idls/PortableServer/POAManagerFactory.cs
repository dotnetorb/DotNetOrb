/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableServer
{
	public abstract partial class POAManagerFactory : CORBA.Object, PortableServer.IPOAManagerFactory
	{
		public static class POAManagerSeqHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(POAManagerSeqHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateAliasTc(PortableServer.POAManagerFactory.POAManagerSeqHelper.Id(), "POAManagerSeq", CORBA.ORB.Init().CreateSequenceTc(0, PortableServer.POAManagerHelper.Type()));
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, PortableServer.IPOAManager[] value)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), value);
			}

			public static PortableServer.IPOAManager[] Extract(CORBA.Any any)
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
				return "IDL:PortableServer/POAManagerFactory/POAManagerSeq:1.0";
			}

			public static PortableServer.IPOAManager[] Read(CORBA.IInputStream inputStream)
			{
				PortableServer.IPOAManager[] result;
				{
					var _capacity0 = inputStream.ReadLong();
					if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
					{
						throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
					}
					result = new PortableServer.IPOAManager[_capacity0];
					for (int i0 = 0; i0 < _capacity0; i0++)
					{
						PortableServer.IPOAManager _item0;
						_item0 = PortableServer.POAManagerHelper.Read(inputStream);
						result[i0] = _item0;
					}
				}
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, PortableServer.IPOAManager[] value)
			{
				{
					outputStream.WriteLong(value.Length);
					for (int i0 = 0; i0 < value.Length; i0++)
					{
						PortableServer.POAManagerHelper.Write(outputStream, value[i0]);
					}
				}
			}

		}
		[IdlName("ManagerAlreadyExists")]
		[RepositoryID("IDL:PortableServer/POAManagerFactory/ManagerAlreadyExists:1.0")]
		[Helper(typeof(ManagerAlreadyExistsHelper))]
		public partial class ManagerAlreadyExists: CORBA.UserException, CORBA.IIDLEntity, IEquatable<PortableServer.POAManagerFactory.ManagerAlreadyExists>
		{
			public ManagerAlreadyExists()
			{
			}

			public ManagerAlreadyExists(string _msg): base(_msg)
			{
			}

			public ManagerAlreadyExists(ManagerAlreadyExists other)
			{
			}

			public bool Equals(PortableServer.POAManagerFactory.ManagerAlreadyExists? other)
			{
				if (other == null) return false;
				return true;
			}
		}

		public static class ManagerAlreadyExistsHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(ManagerAlreadyExistsHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateExceptionTc(PortableServer.POAManagerFactory.ManagerAlreadyExistsHelper.Id(), "ManagerAlreadyExists", new CORBA.StructMember[] {});
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, PortableServer.POAManagerFactory.ManagerAlreadyExists e)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), e);
			}

			public static PortableServer.POAManagerFactory.ManagerAlreadyExists Extract(CORBA.Any any)
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
				return "IDL:PortableServer/POAManagerFactory/ManagerAlreadyExists:1.0";
			}

			public static PortableServer.POAManagerFactory.ManagerAlreadyExists Read(CORBA.IInputStream inputStream)
			{
				var id = inputStream.ReadString();
				if (!id.Equals(Id()))
				{
					throw new CORBA.Marshal("Wrong id: " + id);
				}
				var result = new PortableServer.POAManagerFactory.ManagerAlreadyExists();
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, PortableServer.POAManagerFactory.ManagerAlreadyExists e)
			{
				outputStream.WriteString(Id());
			}

		}
		[IdlName("create_POAManager")]
		[ThrowsIdlException(typeof(PortableServer.POAManagerFactory.ManagerAlreadyExists))]
		[ThrowsIdlException(typeof(CORBA.PolicyError))]
		public abstract PortableServer.IPOAManager CreatePOAManager([WideChar(false)] string id, CORBA.IPolicy[] policies);
		[IdlName("list")]
		public abstract PortableServer.IPOAManager[] List();
		[IdlName("find")]
		public abstract PortableServer.IPOAManager Find([WideChar(false)] string id);
	}
}

