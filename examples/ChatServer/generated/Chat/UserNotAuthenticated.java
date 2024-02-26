package Chat;

/**
 * Generated from IDL exception "UserNotAuthenticated".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public final class UserNotAuthenticated
	extends org.omg.CORBA.UserException
{
	/** Serial version UID. */
	private static final long serialVersionUID = 1L;
	public UserNotAuthenticated()
	{
		super(Chat.UserNotAuthenticatedHelper.id());
	}

	public UserNotAuthenticated(String value)
	{
		super(value);
	}
}
