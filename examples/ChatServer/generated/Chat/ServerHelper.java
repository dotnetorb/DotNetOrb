package Chat;


/**
 * Generated from IDL interface "Server".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class ServerHelper
{
	private volatile static org.omg.CORBA.TypeCode _type;
	public static org.omg.CORBA.TypeCode type ()
	{
		if (_type == null)
		{
			synchronized(ServerHelper.class)
			{
				if (_type == null)
				{
					_type = org.omg.CORBA.ORB.init().create_interface_tc("IDL:Chat/Server:1.0", "Server");
				}
			}
		}
		return _type;
	}

	public static void insert (final org.omg.CORBA.Any any, final Chat.Server s)
	{
			any.insert_Object(s);
	}
	public static Chat.Server extract(final org.omg.CORBA.Any any)
	{
		return narrow(any.extract_Object()) ;
	}
	public static String id()
	{
		return "IDL:Chat/Server:1.0";
	}
	public static Server read(final org.omg.CORBA.portable.InputStream in)
	{
		return narrow(in.read_Object(Chat._ServerStub.class));
	}
	public static void write(final org.omg.CORBA.portable.OutputStream _out, final Chat.Server s)
	{
		_out.write_Object(s);
	}
	public static Chat.Server narrow(final org.omg.CORBA.Object obj)
	{
		if (obj == null)
		{
			return null;
		}
		else if (obj instanceof Chat.Server)
		{
			return (Chat.Server)obj;
		}
		else if (obj._is_a("IDL:Chat/Server:1.0"))
		{
			Chat._ServerStub stub;
			stub = new Chat._ServerStub();
			stub._set_delegate(((org.omg.CORBA.portable.ObjectImpl)obj)._get_delegate());
			return stub;
		}
		else
		{
			throw new org.omg.CORBA.BAD_PARAM("Narrow failed");
		}
	}
	public static Chat.Server unchecked_narrow(final org.omg.CORBA.Object obj)
	{
		if (obj == null)
		{
			return null;
		}
		else if (obj instanceof Chat.Server)
		{
			return (Chat.Server)obj;
		}
		else
		{
			Chat._ServerStub stub;
			stub = new Chat._ServerStub();
			stub._set_delegate(((org.omg.CORBA.portable.ObjectImpl)obj)._get_delegate());
			return stub;
		}
	}
}
