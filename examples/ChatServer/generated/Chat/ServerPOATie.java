package Chat;

import org.omg.PortableServer.POA;

/**
 * Generated from IDL interface "Server".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public class ServerPOATie
	extends ServerPOA
{
	private ServerOperations _delegate;

	private POA _poa;
	public ServerPOATie(ServerOperations delegate)
	{
		_delegate = delegate;
	}
	public ServerPOATie(ServerOperations delegate, POA poa)
	{
		_delegate = delegate;
		_poa = poa;
	}
	public Chat.Server _this()
	{
		org.omg.CORBA.Object __o = _this_object() ;
		Chat.Server __r = Chat.ServerHelper.narrow(__o);
		return __r;
	}
	public Chat.Server _this(org.omg.CORBA.ORB orb)
	{
		org.omg.CORBA.Object __o = _this_object(orb) ;
		Chat.Server __r = Chat.ServerHelper.narrow(__o);
		return __r;
	}
	public ServerOperations _delegate()
	{
		return _delegate;
	}
	public void _delegate(ServerOperations delegate)
	{
		_delegate = delegate;
	}
	public POA _default_POA()
	{
		if (_poa != null)
		{
			return _poa;
		}
		return super._default_POA();
	}
	public java.lang.String Name()
	{
		return _delegate.Name();
	}

	public boolean RegisterUser(Chat.Client clientRef, org.omg.CORBA.IntHolder sessionId) throws Chat.MaxUsersReached
	{
		return _delegate.RegisterUser(clientRef,sessionId);
	}

	public void BroadcastMessage(int sessionId, Chat.Message msg) throws Chat.UserNotAuthenticated
	{
_delegate.BroadcastMessage(sessionId,msg);
	}

	public void UnregisterUser(int sessionId)
	{
_delegate.UnregisterUser(sessionId);
	}

}
