package Chat;


/**
 * Generated from IDL struct "Message".
 *
 * @author JacORB IDL compiler V 3.9
 * @version generated at 14-feb-2024 9:05:56
 */

public abstract class MessageHelper
{
	private volatile static org.omg.CORBA.TypeCode _type;
	public static org.omg.CORBA.TypeCode type ()
	{
		if (_type == null)
		{
			synchronized(MessageHelper.class)
			{
				if (_type == null)
				{
					_type = org.omg.CORBA.ORB.init().create_struct_tc(Chat.MessageHelper.id(),"Message",new org.omg.CORBA.StructMember[]{new org.omg.CORBA.StructMember("priority", org.omg.CORBA.ORB.init().create_enum_tc(Chat.PriorityTypeHelper.id(),"PriorityType",new String[]{"Normal","Urgent"}), null),new org.omg.CORBA.StructMember("subject", org.omg.CORBA.ORB.init().create_wstring_tc(0), null),new org.omg.CORBA.StructMember("body", org.omg.CORBA.ORB.init().create_wstring_tc(0), null)});
				}
			}
		}
		return _type;
	}

	public static void insert (final org.omg.CORBA.Any any, final Chat.Message s)
	{
		any.type(type());
		write( any.create_output_stream(),s);
	}

	public static Chat.Message extract (final org.omg.CORBA.Any any)
	{
		org.omg.CORBA.portable.InputStream in = any.create_input_stream();
		try
		{
			return read (in);
		}
		finally
		{
			try
			{
				in.close();
			}
			catch (java.io.IOException e)
			{
			throw new RuntimeException("Unexpected exception " + e.toString() );
			}
		}
	}

	public static String id()
	{
		return "IDL:Chat/Message:1.0";
	}
	public static Chat.Message read (final org.omg.CORBA.portable.InputStream in)
	{
		Chat.Message result = new Chat.Message();
		result.priority=Chat.PriorityTypeHelper.read(in);
		result.subject=in.read_wstring();
		result.body=in.read_wstring();
		return result;
	}
	public static void write (final org.omg.CORBA.portable.OutputStream out, final Chat.Message s)
	{
		Chat.PriorityTypeHelper.write(out,s.priority);
		java.lang.String tmpResult0 = s.subject;
out.write_wstring( tmpResult0 );
		java.lang.String tmpResult1 = s.body;
out.write_wstring( tmpResult1 );
	}
}
