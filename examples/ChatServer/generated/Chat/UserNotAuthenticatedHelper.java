package Chat;


/**
 * Generated from IDL exception "UserNotAuthenticated".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class UserNotAuthenticatedHelper
{
	private volatile static org.omg.CORBA.TypeCode _type;
	public static org.omg.CORBA.TypeCode type ()
	{
		if (_type == null)
		{
			synchronized(UserNotAuthenticatedHelper.class)
			{
				if (_type == null)
				{
					_type = org.omg.CORBA.ORB.init().create_exception_tc(Chat.UserNotAuthenticatedHelper.id(),"UserNotAuthenticated",new org.omg.CORBA.StructMember[0]);
				}
			}
		}
		return _type;
	}

	public static void insert (final org.omg.CORBA.Any any, final Chat.UserNotAuthenticated s)
	{
		any.type(type());
		write( any.create_output_stream(),s);
	}

	public static Chat.UserNotAuthenticated extract (final org.omg.CORBA.Any any)
	{
		org.omg.CORBA.portable.InputStream in = any.create_input_stream();
		try
		{
			return read (in);
		}
		finally
		{
			try
			{
				in.close();
			}
			catch (java.io.IOException e)
			{
			throw new RuntimeException("Unexpected exception " + e.toString() );
			}
		}
	}

	public static String id()
	{
		return "IDL:Chat/UserNotAuthenticated:1.0";
	}
	public static Chat.UserNotAuthenticated read (final org.omg.CORBA.portable.InputStream in)
	{
		String id = in.read_string();
		if (!id.equals(id())) throw new org.omg.CORBA.MARSHAL("wrong id: " + id);
		final Chat.UserNotAuthenticated result = new Chat.UserNotAuthenticated(id);
		return result;
	}
	public static void write (final org.omg.CORBA.portable.OutputStream out, final Chat.UserNotAuthenticated s)
	{
		out.write_string(id());
	}
}
