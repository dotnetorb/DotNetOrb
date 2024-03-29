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
	[RepositoryID("IDL:Chat/Message:1.0")]
	[Helper(typeof(MessageHelper))]
	public partial class Message: CORBA.IIDLEntity, IEquatable<Chat.Message>
	{
		[IdlName("Message")]
		[WideChar(false)]
		public string From { get; set; }
		[IdlName("Message")]
		public Chat.ColorEnum Color { get; set; }
		[IdlName("Message")]
		[WideChar(true)]
		public string Text { get; set; }

		public Message()
		{
		}

		public Message(Message other)
		{
			From = other.From;
			Color = other.Color;
			Text = other.Text;
		}

		public Message(string from, Chat.ColorEnum color, string text)
		{
			this.From = from;
			this.Color = color;
			this.Text = text;
		}

		public bool Equals(Chat.Message? other)
		{
			if (other == null) return false;
			if (!From.Equals(other.From)) return false;
			if (!Color.Equals(other.Color)) return false;
			if (!Text.Equals(other.Text)) return false;
			return true;
		}
	}

}
