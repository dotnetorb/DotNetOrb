package Chat;

/**
 * Generated from IDL struct "Message".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class MessageHolder
	implements org.omg.CORBA.portable.Streamable
{
	public Chat.Message value;

	public MessageHolder ()
	{
	}
	public MessageHolder(final Chat.Message initial)
	{
		value = initial;
	}
	public org.omg.CORBA.TypeCode _type ()
	{
		return Chat.MessageHelper.type ();
	}
	public void _read(final org.omg.CORBA.portable.InputStream _in)
	{
		value = Chat.MessageHelper.read(_in);
	}
	public void _write(final org.omg.CORBA.portable.OutputStream _out)
	{
		Chat.MessageHelper.write(_out, value);
	}
}
