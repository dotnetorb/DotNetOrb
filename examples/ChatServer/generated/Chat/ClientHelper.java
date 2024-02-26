package Chat;


/**
 * Generated from IDL interface "Client".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class ClientHelper
{
	private volatile static org.omg.CORBA.TypeCode _type;
	public static org.omg.CORBA.TypeCode type ()
	{
		if (_type == null)
		{
			synchronized(ClientHelper.class)
			{
				if (_type == null)
				{
					_type = org.omg.CORBA.ORB.init().create_interface_tc("IDL:Chat/Client:1.0", "Client");
				}
			}
		}
		return _type;
	}

	public static void insert (final org.omg.CORBA.Any any, final Chat.Client s)
	{
			any.insert_Object(s);
	}
	public static Chat.Client extract(final org.omg.CORBA.Any any)
	{
		return narrow(any.extract_Object()) ;
	}
	public static String id()
	{
		return "IDL:Chat/Client:1.0";
	}
	public static Client read(final org.omg.CORBA.portable.InputStream in)
	{
		return narrow(in.read_Object(Chat._ClientStub.class));
	}
	public static void write(final org.omg.CORBA.portable.OutputStream _out, final Chat.Client s)
	{
		_out.write_Object(s);
	}
	public static Chat.Client narrow(final org.omg.CORBA.Object obj)
	{
		if (obj == null)
		{
			return null;
		}
		else if (obj instanceof Chat.Client)
		{
			return (Chat.Client)obj;
		}
		else if (obj._is_a("IDL:Chat/Client:1.0"))
		{
			Chat._ClientStub stub;
			stub = new Chat._ClientStub();
			stub._set_delegate(((org.omg.CORBA.portable.ObjectImpl)obj)._get_delegate());
			return stub;
		}
		else
		{
			throw new org.omg.CORBA.BAD_PARAM("Narrow failed");
		}
	}
	public static Chat.Client unchecked_narrow(final org.omg.CORBA.Object obj)
	{
		if (obj == null)
		{
			return null;
		}
		else if (obj instanceof Chat.Client)
		{
			return (Chat.Client)obj;
		}
		else
		{
			Chat._ClientStub stub;
			stub = new Chat._ClientStub();
			stub._set_delegate(((org.omg.CORBA.portable.ObjectImpl)obj)._get_delegate());
			return stub;
		}
	}
}
