package Chat;

/**
 * Generated from IDL interface "Client".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class ClientHolder	implements org.omg.CORBA.portable.Streamable{
	 public Client value;
	public ClientHolder()
	{
	}
	public ClientHolder (final Client initial)
	{
		value = initial;
	}
	public org.omg.CORBA.TypeCode _type()
	{
		return ClientHelper.type();
	}
	public void _read (final org.omg.CORBA.portable.InputStream in)
	{
		value = ClientHelper.read (in);
	}
	public void _write (final org.omg.CORBA.portable.OutputStream _out)
	{
		ClientHelper.write (_out,value);
	}
}
