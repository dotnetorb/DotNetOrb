package Chat;


/**
 * Generated from IDL interface "Client".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class ClientPOA
	extends org.omg.PortableServer.Servant
	implements org.omg.CORBA.portable.InvokeHandler, Chat.ClientOperations
{
	static private final java.util.HashMap<String,Integer> m_opsHash = new java.util.HashMap<String,Integer>();
	static
	{
		m_opsHash.put ( "_get_Name", Integer.valueOf(0));
		m_opsHash.put ( "SendMessage", Integer.valueOf(1));
	}
	private String[] ids = {"IDL:Chat/Client:1.0"};
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
			java.lang.String tmpResult2 = Name();
_out.write_string( tmpResult2 );
				break;
			}
			case 1: // SendMessage
			{
				Chat.Message _arg0=Chat.MessageHelper.read(_input);
				_out = handler.createReply();
				SendMessage(_arg0);
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
