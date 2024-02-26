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
	public interface IAdminOperations
	{
		[IdlName("list_hosts")]
		public DotNetOrb.ImR.HostInfo[] ListHosts();
		[IdlName("list_servers")]
		public DotNetOrb.ImR.ServerInfo[] ListServers();
		[IdlName("get_server_info")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public DotNetOrb.ImR.ServerInfo GetServerInfo([WideChar(false)] string name);
		[IdlName("shutdown")]
		public void Shutdown(bool wait);
		[IdlName("save_server_table")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.FileOpFailed))]
		public void SaveServerTable();
		[IdlName("register_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.IllegalServerName))]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.DuplicateServerName))]
		public void RegisterServer([WideChar(false)] string name, [WideChar(false)] string command, [WideChar(false)] string host);
		[IdlName("unregister_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void UnregisterServer([WideChar(false)] string name);
		[IdlName("edit_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void EditServer([WideChar(false)] string name, [WideChar(false)] string command, [WideChar(false)] string host);
		[IdlName("hold_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void HoldServer([WideChar(false)] string name);
		[IdlName("release_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		public void ReleaseServer([WideChar(false)] string name);
		[IdlName("start_server")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.UnknownServerName))]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.ServerStartupFailed))]
		public void StartServer([WideChar(false)] string name);
		[IdlName("unregister_host")]
		[ThrowsIdlException(typeof(DotNetOrb.ImR.Admin.UnknownHostName))]
		public void UnregisterHost([WideChar(false)] string name);
	}
}

