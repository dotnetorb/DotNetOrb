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
	public class _AdminStub: CORBA.Object, IAdmin
	{
		private new string[] _ids = {"IDL:DotNetOrb/ImR/Admin:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		public static Type _opsType = typeof(IAdminOperations);

		[IdlName("list_hosts")]
		public DotNetOrb.ImR.HostInfo[] ListHosts()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("list_hosts", true);
					inputStream = _Invoke(outputStream);
					DotNetOrb.ImR.HostInfo[] _result;
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						_result = new DotNetOrb.ImR.HostInfo[_capacity0];
						for (int i0 = 0; i0 < _capacity0; i0++)
						{
							DotNetOrb.ImR.HostInfo _item0;
							_item0 = DotNetOrb.ImR.HostInfoHelper.Read(inputStream);
							_result[i0] = _item0;
						}
					}
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
		[IdlName("list_servers")]
		public DotNetOrb.ImR.ServerInfo[] ListServers()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("list_servers", true);
					inputStream = _Invoke(outputStream);
					DotNetOrb.ImR.ServerInfo[] _result;
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						_result = new DotNetOrb.ImR.ServerInfo[_capacity0];
						for (int i0 = 0; i0 < _capacity0; i0++)
						{
							DotNetOrb.ImR.ServerInfo _item0;
							_item0 = DotNetOrb.ImR.ServerInfoHelper.Read(inputStream);
							_result[i0] = _item0;
						}
					}
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
		[IdlName("get_server_info")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public DotNetOrb.ImR.ServerInfo GetServerInfo([WideChar(false)] string name)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("get_server_info", true);
					outputStream.WriteString(name);
					inputStream = _Invoke(outputStream);
					DotNetOrb.ImR.ServerInfo _result;
					_result = DotNetOrb.ImR.ServerInfoHelper.Read(inputStream);
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
							case "IDL:DotNetOrb/ImR/UnknownServerName:1.0":
								throw DotNetOrb.ImR.UnknownServerNameHelper.Read(aex.InputStream);
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
		[IdlName("shutdown")]
		public void Shutdown(bool wait)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("shutdown", true);
					outputStream.WriteBoolean(wait);
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
		[IdlName("save_server_table")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.FileOpFailed))]
		public void SaveServerTable()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("save_server_table", true);
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
							case "IDL:DotNetOrb/ImR/Admin/FileOpFailed:1.0":
								throw DotNetOrb.ImR.Admin.FileOpFailedHelper.Read(aex.InputStream);
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
		[IdlName("register_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.IllegalServerName))]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.DuplicateServerName))]
		public void RegisterServer([WideChar(false)] string name, [WideChar(false)] string command, [WideChar(false)] string host)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("register_server", true);
					outputStream.WriteString(name);
					outputStream.WriteString(command);
					outputStream.WriteString(host);
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
							case "IDL:DotNetOrb/ImR/Admin/IllegalServerName:1.0":
								throw DotNetOrb.ImR.Admin.IllegalServerNameHelper.Read(aex.InputStream);
							case "IDL:DotNetOrb/ImR/Admin/DuplicateServerName:1.0":
								throw DotNetOrb.ImR.Admin.DuplicateServerNameHelper.Read(aex.InputStream);
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
		[IdlName("unregister_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void UnregisterServer([WideChar(false)] string name)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("unregister_server", true);
					outputStream.WriteString(name);
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
							case "IDL:DotNetOrb/ImR/UnknownServerName:1.0":
								throw DotNetOrb.ImR.UnknownServerNameHelper.Read(aex.InputStream);
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
		[IdlName("edit_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void EditServer([WideChar(false)] string name, [WideChar(false)] string command, [WideChar(false)] string host)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("edit_server", true);
					outputStream.WriteString(name);
					outputStream.WriteString(command);
					outputStream.WriteString(host);
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
							case "IDL:DotNetOrb/ImR/UnknownServerName:1.0":
								throw DotNetOrb.ImR.UnknownServerNameHelper.Read(aex.InputStream);
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
		[IdlName("hold_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void HoldServer([WideChar(false)] string name)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("hold_server", true);
					outputStream.WriteString(name);
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
							case "IDL:DotNetOrb/ImR/UnknownServerName:1.0":
								throw DotNetOrb.ImR.UnknownServerNameHelper.Read(aex.InputStream);
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
		[IdlName("release_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void ReleaseServer([WideChar(false)] string name)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("release_server", true);
					outputStream.WriteString(name);
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
							case "IDL:DotNetOrb/ImR/UnknownServerName:1.0":
								throw DotNetOrb.ImR.UnknownServerNameHelper.Read(aex.InputStream);
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
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.ServerStartupFailed))]
		public void StartServer([WideChar(false)] string name)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("start_server", true);
					outputStream.WriteString(name);
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
							case "IDL:DotNetOrb/ImR/UnknownServerName:1.0":
								throw DotNetOrb.ImR.UnknownServerNameHelper.Read(aex.InputStream);
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
		[IdlName("unregister_host")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.UnknownHostName))]
		public void UnregisterHost([WideChar(false)] string name)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("unregister_host", true);
					outputStream.WriteString(name);
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
							case "IDL:DotNetOrb/ImR/Admin/UnknownHostName:1.0":
								throw DotNetOrb.ImR.Admin.UnknownHostNameHelper.Read(aex.InputStream);
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
