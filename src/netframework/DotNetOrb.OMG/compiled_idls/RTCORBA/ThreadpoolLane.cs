/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:28
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;

namespace RTCORBA
{
	[RepositoryID("IDL:RTCORBA/ThreadpoolLane:1.0")]
	[Helper(typeof(ThreadpoolLaneHelper))]
	public partial class ThreadpoolLane: CORBA.IIDLEntity, IEquatable<RTCORBA.ThreadpoolLane>
	{
		[IdlName("ThreadpoolLane")]
		public short LanePriority { get; set; }
		[IdlName("ThreadpoolLane")]
		public uint StaticThreads { get; set; }
		[IdlName("ThreadpoolLane")]
		public uint DynamicThreads { get; set; }

		public ThreadpoolLane()
		{
		}

		public ThreadpoolLane(ThreadpoolLane other)
		{
			LanePriority = other.LanePriority;
			StaticThreads = other.StaticThreads;
			DynamicThreads = other.DynamicThreads;
		}

		public ThreadpoolLane(short lanePriority, uint staticThreads, uint dynamicThreads)
		{
			this.LanePriority = lanePriority;
			this.StaticThreads = staticThreads;
			this.DynamicThreads = dynamicThreads;
		}

		public bool Equals(RTCORBA.ThreadpoolLane? other)
		{
			if (other == null) return false;
			if (!LanePriority.Equals(other.LanePriority)) return false;
			if (!StaticThreads.Equals(other.StaticThreads)) return false;
			if (!DynamicThreads.Equals(other.DynamicThreads)) return false;
			return true;
		}
	}

}
