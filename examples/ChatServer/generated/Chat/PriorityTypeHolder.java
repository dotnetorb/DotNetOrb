package Chat;
/**
 * Generated from IDL enum "PriorityType".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class PriorityTypeHolder
	implements org.omg.CORBA.portable.Streamable
{
	public PriorityType value;

	public PriorityTypeHolder ()
	{
	}
	public PriorityTypeHolder (final PriorityType initial)
	{
		value = initial;
	}
	public org.omg.CORBA.TypeCode _type ()
	{
		return PriorityTypeHelper.type ();
	}
	public void _read (final org.omg.CORBA.portable.InputStream in)
	{
		value = PriorityTypeHelper.read (in);
	}
	public void _write (final org.omg.CORBA.portable.OutputStream out)
	{
		PriorityTypeHelper.write (out,value);
	}
}
