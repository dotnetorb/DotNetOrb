package Chat;

/**
 * Generated from IDL exception "MaxUsersReached".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class MaxUsersReached
	extends org.omg.CORBA.UserException
{
	/** Serial version UID. */
	private static final long serialVersionUID = 1L;
	public MaxUsersReached()
	{
		super(Chat.MaxUsersReachedHelper.id());
	}

	public int numUsers;
	public MaxUsersReached(java.lang.String _reason,int numUsers)
	{
		super(_reason);
		this.numUsers = numUsers;
	}
	public MaxUsersReached(int numUsers)
	{
		super(Chat.MaxUsersReachedHelper.id());
		this.numUsers = numUsers;
	}
}
