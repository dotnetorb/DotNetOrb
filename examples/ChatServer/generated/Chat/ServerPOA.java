package Chat;


/**
 * Generated from IDL interface "Server".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class ServerPOA
	extends org.omg.PortableServer.Servant
	implements org.omg.CORBA.portable.InvokeHandler, Chat.ServerOperations
{
	static private final java.util.HashMap<String,Integer> m_opsHash = new java.util.HashMap<String,Integer>();
	static
	{
		m_opsHash.put ( "_get_Name", Integer.valueOf(0));
		m_opsHash.put ( "RegisterUser", Integer.valueOf(1));
		m_opsHash.put ( "BroadcastMessage", Integer.valueOf(2));
		m_opsHash.put ( "UnregisterUser", Integer.valueOf(3));
	}
	private String[] ids = {"IDL:Chat/Server:1.0"};
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
	public org.omg.CORBA.portable.OutputStream _invoke(String method, org.omg.CORBA.portable.InputStream _input, org.omg.CORBA.portable.ResponseHandler handler)
		throws org.omg.CORBA.SystemException
	{
		org.omg.CORBA.portable.OutputStream _out = null;
		// do something
		// quick lookup of operation
		java.lang.Integer opsIndex = (java.lang.Integer)m_opsHash.get ( method );
		if ( null == opsIndex )
			throw new org.omg.CORBA.BAD_OPERATION(method + " not found");
		switch ( opsIndex.intValue() )
		{
			case 0: // _get_Name
			{
			_out = handler.createReply();
			java.lang.String tmpResult3 = Name();
_out.write_string( tmpResult3 );
				break;
			}
			case 1: // RegisterUser
			{
			try
			{
				Chat.Client _arg0=Chat.ClientHelper.read(_input);
				org.omg.CORBA.IntHolder _arg1= new org.omg.CORBA.IntHolder();
				_out = handler.createReply();
				_out.write_boolean(RegisterUser(_arg0,_arg1));
				_out.write_long(_arg1.value);
			}
			catch(Chat.MaxUsersReached _ex0)
			{
				_out = handler.createExceptionReply();
				Chat.MaxUsersReachedHelper.write(_out, _ex0);
			}
				break;
			}
			case 2: // BroadcastMessage
			{
			try
			{
				int _arg0=_input.read_long();
				Chat.Message _arg1=Chat.MessageHelper.read(_input);
				_out = handler.createReply();
				BroadcastMessage(_arg0,_arg1);
			}
			catch(Chat.UserNotAuthenticated _ex0)
			{
				_out = handler.createExceptionReply();
				Chat.UserNotAuthenticatedHelper.write(_out, _ex0);
			}
				break;
			}
			case 3: // UnregisterUser
			{
				int _arg0=_input.read_long();
				_out = handler.createReply();
				UnregisterUser(_arg0);
				break;
			}
		}
		return _out;
	}

	public String[] _all_interfaces(org.omg.PortableServer.POA poa, byte[] obj_id)
	{
		return ids;
	}
}
