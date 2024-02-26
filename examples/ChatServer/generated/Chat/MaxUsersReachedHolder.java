package Chat;

/**
 * Generated from IDL exception "MaxUsersReached".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class MaxUsersReachedHolder
	implements org.omg.CORBA.portable.Streamable
{
	public Chat.MaxUsersReached value;

	public MaxUsersReachedHolder ()
	{
	}
	public MaxUsersReachedHolder(final Chat.MaxUsersReached initial)
	{
		value = initial;
	}
	public org.omg.CORBA.TypeCode _type ()
	{
		return Chat.MaxUsersReachedHelper.type ();
	}
	public void _read(final org.omg.CORBA.portable.InputStream _in)
	{
		value = Chat.MaxUsersReachedHelper.read(_in);
	}
	public void _write(final org.omg.CORBA.portable.OutputStream _out)
	{
		Chat.MaxUsersReachedHelper.write(_out, value);
	}
}
