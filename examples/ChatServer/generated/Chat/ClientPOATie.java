package Chat;

import org.omg.PortableServer.POA;

/**
 * Generated from IDL interface "Client".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public class ClientPOATie
	extends ClientPOA
{
	private ClientOperations _delegate;

	private POA _poa;
	public ClientPOATie(ClientOperations delegate)
	{
		_delegate = delegate;
	}
	public ClientPOATie(ClientOperations delegate, POA poa)
	{
		_delegate = delegate;
		_poa = poa;
	}
	public Chat.Client _this()
	{
		org.omg.CORBA.Object __o = _this_object() ;
		Chat.Client __r = Chat.ClientHelper.narrow(__o);
		return __r;
	}
	public Chat.Client _this(org.omg.CORBA.ORB orb)
	{
		org.omg.CORBA.Object __o = _this_object(orb) ;
		Chat.Client __r = Chat.ClientHelper.narrow(__o);
		return __r;
	}
	public ClientOperations _delegate()
	{
		return _delegate;
	}
	public void _delegate(ClientOperations delegate)
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

	public void SendMessage(Chat.Message msg)
	{
_delegate.SendMessage(msg);
	}

}
