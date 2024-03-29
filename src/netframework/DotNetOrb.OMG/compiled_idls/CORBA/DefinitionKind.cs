/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	[IdlName("DefinitionKind")]
	[RepositoryID("IDL:CORBA/DefinitionKind:1.0")]
	[Helper(typeof(DefinitionKindHelper))]
	public enum DefinitionKind
	{
		[IdlName("dk_none")]
		DkNone = 0,
		[IdlName("dk_all")]
		DkAll = 1,
		[IdlName("dk_Attribute")]
		DkAttribute = 2,
		[IdlName("dk_Constant")]
		DkConstant = 3,
		[IdlName("dk_Exception")]
		DkException = 4,
		[IdlName("dk_Interface")]
		DkInterface = 5,
		[IdlName("dk_Module")]
		DkModule = 6,
		[IdlName("dk_Operation")]
		DkOperation = 7,
		[IdlName("dk_Typedef")]
		DkTypedef = 8,
		[IdlName("dk_Alias")]
		DkAlias = 9,
		[IdlName("dk_Struct")]
		DkStruct = 10,
		[IdlName("dk_Union")]
		DkUnion = 11,
		[IdlName("dk_Enum")]
		DkEnum = 12,
		[IdlName("dk_Primitive")]
		DkPrimitive = 13,
		[IdlName("dk_String")]
		DkString = 14,
		[IdlName("dk_Sequence")]
		DkSequence = 15,
		[IdlName("dk_Array")]
		DkArray = 16,
		[IdlName("dk_Repository")]
		DkRepository = 17,
		[IdlName("dk_Wstring")]
		DkWstring = 18,
		[IdlName("dk_Fixed")]
		DkFixed = 19,
		[IdlName("dk_Value")]
		DkValue = 20,
		[IdlName("dk_ValueBox")]
		DkValueBox = 21,
		[IdlName("dk_ValueMember")]
		DkValueMember = 22,
		[IdlName("dk_Native")]
		DkNative = 23,
		[IdlName("dk_AbstractInterface")]
		DkAbstractInterface = 24,
		[IdlName("dk_LocalInterface")]
		DkLocalInterface = 25,
		[IdlName("dk_Component")]
		DkComponent = 26,
		[IdlName("dk_Home")]
		DkHome = 27,
		[IdlName("dk_Factory")]
		DkFactory = 28,
		[IdlName("dk_Finder")]
		DkFinder = 29,
		[IdlName("dk_Emits")]
		DkEmits = 30,
		[IdlName("dk_Publishes")]
		DkPublishes = 31,
		[IdlName("dk_Consumes")]
		DkConsumes = 32,
		[IdlName("dk_Provides")]
		DkProvides = 33,
		[IdlName("dk_Uses")]
		DkUses = 34,
		[IdlName("dk_Event")]
		DkEvent = 35,
	}

}
