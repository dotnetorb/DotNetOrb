/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:27
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public abstract partial class Contained : CORBA.Object, CORBA.IContained
	{
		[RepositoryID("IDL:CORBA/Contained/Description:1.0")]
		[Helper(typeof(DescriptionHelper))]
		public partial class Description: CORBA.IIDLEntity, IEquatable<CORBA.Contained.Description>
		{
			[IdlName("Description")]
			public CORBA.DefinitionKind Kind { get; set; }
			[IdlName("Description")]
			public CORBA.Any Value { get; set; }

			public Description()
			{
			}

			public Description(Description other)
			{
				Kind = other.Kind;
				Value = other.Value;
			}

			public Description(CORBA.DefinitionKind kind, CORBA.Any value)
			{
				this.Kind = kind;
				this.Value = value;
			}

			public bool Equals(CORBA.Contained.Description? other)
			{
				if (other == null) return false;
				if (!Kind.Equals(other.Kind)) return false;
				if (!Value.Equals(other.Value)) return false;
				return true;
			}
		}

		public static class DescriptionHelper
		{
			private static volatile CORBA.TypeCode type;

			public static CORBA.TypeCode Type()
			{
				if (type == null)
				{
					lock (typeof(DescriptionHelper))
					{
						if (type == null)
						{
							type = CORBA.ORB.Init().CreateStructTc(CORBA.Contained.DescriptionHelper.Id(), "Description", new CORBA.StructMember[] {new CORBA.StructMember("kind", CORBA.DefinitionKindHelper.Type(), null), new CORBA.StructMember("value", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 11), null), });
						}
					}
				}
				return type;
			}

			public static void Insert(CORBA.Any any, CORBA.Contained.Description s)
			{
				any.Type = Type();
				Write(any.CreateOutputStream(), s);
			}

			public static CORBA.Contained.Description Extract(CORBA.Any any)
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
				return "IDL:CORBA/Contained/Description:1.0";
			}

			public static CORBA.Contained.Description Read(CORBA.IInputStream inputStream)
			{
				var result = new CORBA.Contained.Description();
				result.Kind = CORBA.DefinitionKindHelper.Read(inputStream);
				result.Value = inputStream.ReadAny();
				return result;
			}

			public static void Write(CORBA.IOutputStream outputStream, CORBA.Contained.Description s)
			{
				CORBA.DefinitionKindHelper.Write(outputStream, s.Kind);
				outputStream.WriteAny(s.Value);
			}

		}
		[IdlName("def_kind")]
		public abstract CORBA.DefinitionKind DefKind 
		{
			get;
		}
		[IdlName("destroy")]
		public abstract void Destroy();
		[IdlName("id")]
		[WideChar(false)]
		public abstract string Id 
		{
			get;

			set;
		}
		[IdlName("name")]
		[WideChar(false)]
		public abstract string Name 
		{
			get;

			set;
		}
		[IdlName("version")]
		[WideChar(false)]
		public abstract string Version 
		{
			get;

			set;
		}
		[IdlName("defined_in")]
		public abstract CORBA.IContainer DefinedIn 
		{
			get;
		}
		[IdlName("absolute_name")]
		[WideChar(false)]
		public abstract string AbsoluteName 
		{
			get;
		}
		[IdlName("containing_repository")]
		public abstract CORBA.IRepository ContainingRepository 
		{
			get;
		}
		[IdlName("describe")]
		public abstract CORBA.Contained.Description Describe();
		[IdlName("move")]
		public abstract void Move(CORBA.IContainer newContainer, [WideChar(false)] string newName, [WideChar(false)] string newVersion);
	}
}

