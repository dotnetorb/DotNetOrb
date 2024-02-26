package Chat;

/**
 * Generated from IDL struct "Message".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class Message
	implements org.omg.CORBA.portable.IDLEntity
{
	/** Serial version UID. */
	private static final long serialVersionUID = 1L;
	public Message(){}
	public Chat.PriorityType priority;
	public java.lang.String subject = "";
	public java.lang.String body = "";
	public Message(Chat.PriorityType priority, java.lang.String subject, java.lang.String body)
	{
		this.priority = priority;
		this.subject = subject;
		this.body = body;
	}
}
