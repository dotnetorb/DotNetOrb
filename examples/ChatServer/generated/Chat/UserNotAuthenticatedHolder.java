package Chat;

/**
 * Generated from IDL exception "UserNotAuthenticated".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class UserNotAuthenticatedHolder
	implements org.omg.CORBA.portable.Streamable
{
	public Chat.UserNotAuthenticated value;

	public UserNotAuthenticatedHolder ()
	{
	}
	public UserNotAuthenticatedHolder(final Chat.UserNotAuthenticated initial)
	{
		value = initial;
	}
	public org.omg.CORBA.TypeCode _type ()
	{
		return Chat.UserNotAuthenticatedHelper.type ();
	}
	public void _read(final org.omg.CORBA.portable.InputStream _in)
	{
		value = Chat.UserNotAuthenticatedHelper.read(_in);
	}
	public void _write(final org.omg.CORBA.portable.OutputStream _out)
	{
		Chat.UserNotAuthenticatedHelper.write(_out, value);
	}
}
