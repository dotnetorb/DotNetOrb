/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 26/02/2024 12:18:44
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace Chat
{
	[IdlName("UserNotAuthenticated")]
	[RepositoryID("IDL:Chat/UserNotAuthenticated:1.0")]
	[Helper(typeof(UserNotAuthenticatedHelper))]
	public partial class UserNotAuthenticated: CORBA.UserException, CORBA.IIDLEntity, IEquatable<Chat.UserNotAuthenticated>
	{
		public UserNotAuthenticated()
		{
		}

		public UserNotAuthenticated(string _msg): base(_msg)
		{
		}

		public UserNotAuthenticated(UserNotAuthenticated other)
		{
		}

		public bool Equals(Chat.UserNotAuthenticated? other)
		{
			if (other == null) return false;
			return true;
		}
	}

}