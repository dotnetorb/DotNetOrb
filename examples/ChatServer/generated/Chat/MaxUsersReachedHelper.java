package Chat;


/**
 * Generated from IDL exception "MaxUsersReached".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class MaxUsersReachedHelper
{
	private volatile static org.omg.CORBA.TypeCode _type;
	public static org.omg.CORBA.TypeCode type ()
	{
		if (_type == null)
		{
			synchronized(MaxUsersReachedHelper.class)
			{
				if (_type == null)
				{
					_type = org.omg.CORBA.ORB.init().create_exception_tc(Chat.MaxUsersReachedHelper.id(),"MaxUsersReached",new org.omg.CORBA.StructMember[]{new org.omg.CORBA.StructMember("numUsers", org.omg.CORBA.ORB.init().get_primitive_tc(org.omg.CORBA.TCKind.from_int(3)), null)});
				}
			}
		}
		return _type;
	}

	public static void insert (final org.omg.CORBA.Any any, final Chat.MaxUsersReached s)
	{
		any.type(type());
		write( any.create_output_stream(),s);
	}

	public static Chat.MaxUsersReached extract (final org.omg.CORBA.Any any)
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
		return "IDL:Chat/MaxUsersReached:1.0";
	}
	public static Chat.MaxUsersReached read (final org.omg.CORBA.portable.InputStream in)
	{
		String id = in.read_string();
		if (!id.equals(id())) throw new org.omg.CORBA.MARSHAL("wrong id: " + id);
		int x0;
		x0=in.read_long();
		final Chat.MaxUsersReached result = new Chat.MaxUsersReached(id, x0);
		return result;
	}
	public static void write (final org.omg.CORBA.portable.OutputStream out, final Chat.MaxUsersReached s)
	{
		out.write_string(id());
		out.write_long(s.numUsers);
	}
}
