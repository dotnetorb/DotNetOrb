/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:37
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace DotNetOrb.ImR
{
	public class _ServerStartupDaemonStub: CORBA.Object, IServerStartupDaemon
	{
		private new string[] _ids = {"IDL:DotNetOrb/ImR/ServerStartupDaemon:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		public static Type _opsType = typeof(IServerStartupDaemonOperations);

		[IdlName("get_system_load")]
		public int GetSystemLoad()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("get_system_load", true);
					inputStream = _Invoke(outputStream);
					int _result;
					_result = inputStream.ReadLong();
					return _result;
				}
				catch(RemarshalException)
				{
					continue;
				}
				catch(CORBA.ApplicationException aex)
				{
					try
					{
						switch (aex.Id)
						{
							default:
								throw new RuntimeException("Unexpected exception " + aex.Id);
						}						
					}
					finally
					{
						try
						{
							aex.InputStream.Close();
						}
						catch (Exception ex)
						{
							throw new RuntimeException("Unexpected exception " + ex.ToString());
						}
					}
				}
				finally
				{
					if (outputStream != null)
					{
						try
						{
							outputStream.Close();
						}
						catch (Exception e)
						{
							throw new RuntimeException("Unexpected exception " + e.ToString());
						}
					}
					if (inputStream != null)
					{
						this._ReleaseReply(inputStream);
					}
				}
			}
		}
		[IdlName("start_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.ServerStartupFailed))]
		public void StartServer([WideChar(false)] string command)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("start_server", true);
					outputStream.WriteString(command);
					inputStream = _Invoke(outputStream);
					return;
				}
				catch(RemarshalException)
				{
					continue;
				}
				catch(CORBA.ApplicationException aex)
				{
					try
					{
						switch (aex.Id)
						{
							case "IDL:DotNetOrb/ImR/ServerStartupFailed:1.0":
								throw DotNetOrb.ImR.ServerStartupFailedHelper.Read(aex.InputStream);
							default:
								throw new RuntimeException("Unexpected exception " + aex.Id);
						}						
					}
					finally
					{
						try
						{
							aex.InputStream.Close();
						}
						catch (Exception ex)
						{
							throw new RuntimeException("Unexpected exception " + ex.ToString());
						}
					}
				}
				finally
				{
					if (outputStream != null)
					{
						try
						{
							outputStream.Close();
						}
						catch (Exception e)
						{
							throw new RuntimeException("Unexpected exception " + e.ToString());
						}
					}
					if (inputStream != null)
					{
						this._ReleaseReply(inputStream);
					}
				}
			}
		}

	}

}
