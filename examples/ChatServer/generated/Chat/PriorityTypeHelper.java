package Chat;
/**
 * Generated from IDL enum "PriorityType".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class PriorityTypeHelper
{
	private volatile static org.omg.CORBA.TypeCode _type;
	public static org.omg.CORBA.TypeCode type ()
	{
		if (_type == null)
		{
			synchronized(PriorityTypeHelper.class)
			{
				if (_type == null)
				{
					_type = org.omg.CORBA.ORB.init().create_enum_tc(Chat.PriorityTypeHelper.id(),"PriorityType",new String[]{"Normal","Urgent"});
				}
			}
		}
		return _type;
	}

	public static void insert (final org.omg.CORBA.Any any, final Chat.PriorityType s)
	{
		any.type(type());
		write( any.create_output_stream(),s);
	}

	public static Chat.PriorityType extract (final org.omg.CORBA.Any any)
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
		return "IDL:Chat/PriorityType:1.0";
	}
	public static PriorityType read (final org.omg.CORBA.portable.InputStream in)
	{
		return PriorityType.from_int(in.read_long());
	}

	public static void write (final org.omg.CORBA.portable.OutputStream out, final PriorityType s)
	{
		out.write_long(s.value());
	}
}
