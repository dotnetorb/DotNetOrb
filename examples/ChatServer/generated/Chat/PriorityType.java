package Chat;
/**
 * Generated from IDL enum "PriorityType".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class PriorityType
	implements org.omg.CORBA.portable.IDLEntity
{
	/** Serial version UID. */
	private static final long serialVersionUID = 1L;
	private int value = -1;
	public static final int _Normal = 0;
	public static final PriorityType Normal = new PriorityType(_Normal);
	public static final int _Urgent = 1;
	public static final PriorityType Urgent = new PriorityType(_Urgent);
	public int value()
	{
		return value;
	}
	public static PriorityType from_int(int value)
	{
		switch (value) {
			case _Normal: return Normal;
			case _Urgent: return Urgent;
			default: throw new org.omg.CORBA.BAD_PARAM();
		}
	}
	public String toString()
	{
		switch (value) {
			case _Normal: return "Normal";
			case _Urgent: return "Urgent";
			default: throw new org.omg.CORBA.BAD_PARAM();
		}
	}
	protected PriorityType(int i)
	{
		value = i;
	}
	/**
	 * Designate replacement object when deserialized from stream. See
	 * http://www.omg.org/docs/ptc/02-01-03.htm#Issue4271
	 *
	 * @throws java.io.ObjectStreamException
	 */
	java.lang.Object readResolve()
	throws java.io.ObjectStreamException
	{
		return from_int(value());
	}
}
