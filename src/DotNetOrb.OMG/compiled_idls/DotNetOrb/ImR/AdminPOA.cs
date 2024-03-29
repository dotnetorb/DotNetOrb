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

	public abstract class AdminPOA: PortableServer.Servant, CORBA.IInvokeHandler, IAdminOperations
	{
		static private Dictionary<string,int> _opsDict = new Dictionary<string,int>();
		static AdminPOA()
		{
			_opsDict.Add("list_hosts", 0);
			_opsDict.Add("list_servers", 1);
			_opsDict.Add("get_server_info", 2);
			_opsDict.Add("shutdown", 3);
			_opsDict.Add("save_server_table", 4);
			_opsDict.Add("register_server", 5);
			_opsDict.Add("unregister_server", 6);
			_opsDict.Add("edit_server", 7);
			_opsDict.Add("hold_server", 8);
			_opsDict.Add("release_server", 9);
			_opsDict.Add("start_server", 10);
			_opsDict.Add("unregister_host", 11);
		}
		private string[] _ids = {"IDL:DotNetOrb/ImR/Admin:1.0"};

		[IdlName("list_hosts")]
		public abstract DotNetOrb.ImR.HostInfo[] ListHosts();
		[IdlName("list_servers")]
		public abstract DotNetOrb.ImR.ServerInfo[] ListServers();
		[IdlName("get_server_info")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public abstract DotNetOrb.ImR.ServerInfo GetServerInfo([WideChar(false)] string name);
		[IdlName("shutdown")]
		public abstract void Shutdown(bool wait);
		[IdlName("save_server_table")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.FileOpFailed))]
		public abstract void SaveServerTable();
		[IdlName("register_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.IllegalServerName))]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.DuplicateServerName))]
		public abstract void RegisterServer([WideChar(false)] string name, [WideChar(false)] string command, [WideChar(false)] string host);
		[IdlName("unregister_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public abstract void UnregisterServer([WideChar(false)] string name);
		[IdlName("edit_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public abstract void EditServer([WideChar(false)] string name, [WideChar(false)] string command, [WideChar(false)] string host);
		[IdlName("hold_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public abstract void HoldServer([WideChar(false)] string name);
		[IdlName("release_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public abstract void ReleaseServer([WideChar(false)] string name);
		[IdlName("start_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.ServerStartupFailed))]
		public abstract void StartServer([WideChar(false)] string name);
		[IdlName("unregister_host")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.UnknownHostName))]
		public abstract void UnregisterHost([WideChar(false)] string name);

		public override string[] _AllInterfaces(PortableServer.IPOA poa, byte[] objId)
		{
			return _ids;
		}

		public virtual DotNetOrb.ImR.IAdmin _This()
		{
			return DotNetOrb.ImR.AdminHelper.Narrow(_ThisObject());
		}

		public virtual DotNetOrb.ImR.IAdmin _This(CORBA.ORB orb)
		{
			return DotNetOrb.ImR.AdminHelper.Narrow(_ThisObject(orb));
		}

		public CORBA.IOutputStream _Invoke(string method, CORBA.IInputStream inputStream, CORBA.IResponseHandler handler)
		{
			CORBA.IOutputStream outputStream = null;
			int opIndex;
			if (_opsDict.TryGetValue(method, out opIndex))
			{
				switch (opIndex)
				{
					case 0:
					{
							outputStream = handler.CreateReply();
							var _result = ListHosts();
							{
								outputStream.WriteLong(_result.Length);
								for (int i0 = 0; i0 < _result.Length; i0++)
								{
									DotNetOrb.ImR.HostInfoHelper.Write(outputStream, _result[i0]);
								}
							}
					}
					break;
					case 1:
					{
							outputStream = handler.CreateReply();
							var _result = ListServers();
							{
								outputStream.WriteLong(_result.Length);
								for (int i0 = 0; i0 < _result.Length; i0++)
								{
									DotNetOrb.ImR.ServerInfoHelper.Write(outputStream, _result[i0]);
								}
							}
					}
					break;
					case 2:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							outputStream = handler.CreateReply();
							var _result = GetServerInfo(name);
							DotNetOrb.ImR.ServerInfoHelper.Write(outputStream, _result);
						}
						catch(DotNetOrb.ImR.UnknownServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.UnknownServerNameHelper.Write(outputStream, ex);
						}
					}
					break;
					case 3:
					{
							bool wait;
							wait = inputStream.ReadBoolean();
							outputStream = handler.CreateReply();
							Shutdown(wait);
					}
					break;
					case 4:
					{
						try
						{
							outputStream = handler.CreateReply();
							SaveServerTable();
						}
						catch(DotNetOrb.ImR.Admin.FileOpFailed ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.Admin.FileOpFailedHelper.Write(outputStream, ex);
						}
					}
					break;
					case 5:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							string command;
							command = inputStream.ReadString();
							string host;
							host = inputStream.ReadString();
							outputStream = handler.CreateReply();
							RegisterServer(name,command,host);
						}
						catch(DotNetOrb.ImR.Admin.IllegalServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.Admin.IllegalServerNameHelper.Write(outputStream, ex);
						}
						catch(DotNetOrb.ImR.Admin.DuplicateServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.Admin.DuplicateServerNameHelper.Write(outputStream, ex);
						}
					}
					break;
					case 6:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							outputStream = handler.CreateReply();
							UnregisterServer(name);
						}
						catch(DotNetOrb.ImR.UnknownServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.UnknownServerNameHelper.Write(outputStream, ex);
						}
					}
					break;
					case 7:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							string command;
							command = inputStream.ReadString();
							string host;
							host = inputStream.ReadString();
							outputStream = handler.CreateReply();
							EditServer(name,command,host);
						}
						catch(DotNetOrb.ImR.UnknownServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.UnknownServerNameHelper.Write(outputStream, ex);
						}
					}
					break;
					case 8:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							outputStream = handler.CreateReply();
							HoldServer(name);
						}
						catch(DotNetOrb.ImR.UnknownServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.UnknownServerNameHelper.Write(outputStream, ex);
						}
					}
					break;
					case 9:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							outputStream = handler.CreateReply();
							ReleaseServer(name);
						}
						catch(DotNetOrb.ImR.UnknownServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.UnknownServerNameHelper.Write(outputStream, ex);
						}
					}
					break;
					case 10:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							outputStream = handler.CreateReply();
							StartServer(name);
						}
						catch(DotNetOrb.ImR.UnknownServerName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.UnknownServerNameHelper.Write(outputStream, ex);
						}
						catch(DotNetOrb.ImR.ServerStartupFailed ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.ServerStartupFailedHelper.Write(outputStream, ex);
						}
					}
					break;
					case 11:
					{
						try
						{
							string name;
							name = inputStream.ReadString();
							outputStream = handler.CreateReply();
							UnregisterHost(name);
						}
						catch(DotNetOrb.ImR.Admin.UnknownHostName ex)
						{
							outputStream = handler.CreateExceptionReply();
							DotNetOrb.ImR.Admin.UnknownHostNameHelper.Write(outputStream, ex);
						}
					}
					break;
				}
				return outputStream;
			}
			else
			{
				throw new CORBA.BadOperation(method + " not found");
			}
		}
	}
}
