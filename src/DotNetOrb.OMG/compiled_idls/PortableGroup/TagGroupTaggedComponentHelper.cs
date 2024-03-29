/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:30
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace PortableGroup
{
	public static class TagGroupTaggedComponentHelper
	{
		private static volatile CORBA.TypeCode type;

		public static CORBA.TypeCode Type()
		{
			if (type == null)
			{
				lock (typeof(TagGroupTaggedComponentHelper))
				{
					if (type == null)
					{
						type = CORBA.ORB.Init().CreateStructTc(PortableGroup.TagGroupTaggedComponentHelper.Id(), "TagGroupTaggedComponent", new CORBA.StructMember[] {new CORBA.StructMember("group_version", GIOP.VersionHelper.Type(), null), new CORBA.StructMember("group_domain_id", CORBA.ORB.Init().CreateStringTc(0), null), new CORBA.StructMember("object_group_id", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 24), null), new CORBA.StructMember("object_group_ref_version", CORBA.ORB.Init().GetPrimitiveTc((CORBA.TCKind) 5), null), });
					}
				}
			}
			return type;
		}

		public static void Insert(CORBA.Any any, PortableGroup.TagGroupTaggedComponent s)
		{
			any.Type = Type();
			Write(any.CreateOutputStream(), s);
		}

		public static PortableGroup.TagGroupTaggedComponent Extract(CORBA.Any any)
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
			return "IDL:omg.org/PortableGroup/TagGroupTaggedComponent:1.0";
		}

		public static PortableGroup.TagGroupTaggedComponent Read(CORBA.IInputStream inputStream)
		{
			var result = new PortableGroup.TagGroupTaggedComponent();
			result.GroupVersion = GIOP.VersionHelper.Read(inputStream);
			result.GroupDomainId = inputStream.ReadString();
			result.ObjectGroupId = inputStream.ReadULongLong();
			result.ObjectGroupRefVersion = inputStream.ReadULong();
			return result;
		}

		public static void Write(CORBA.IOutputStream outputStream, PortableGroup.TagGroupTaggedComponent s)
		{
			GIOP.VersionHelper.Write(outputStream, s.GroupVersion);
			outputStream.WriteString(s.GroupDomainId);
			outputStream.WriteULongLong(s.ObjectGroupId);
			outputStream.WriteULong(s.ObjectGroupRefVersion);
		}

	}
}
