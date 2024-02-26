package Chat;


/**
 * Generated from IDL interface "Server".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public interface ServerOperations
{
	/* constants */
	/* operations  */
	java.lang.String Name();
	boolean RegisterUser(Chat.Client clientRef, org.omg.CORBA.IntHolder sessionId) throws Chat.MaxUsersReached;
	void UnregisterUser(int sessionId);
	void BroadcastMessage(int sessionId, Chat.Message msg) throws Chat.UserNotAuthenticated;
}
