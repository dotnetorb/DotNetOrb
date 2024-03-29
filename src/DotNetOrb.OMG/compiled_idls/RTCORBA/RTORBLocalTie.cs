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

	public class RTORBLocalTie: _RTORBLocalBase
	{
		public IRTORBOperations _OperationsDelegate { get; set; }

		public RTORBLocalTie(IRTORBOperations d)
		{
			_OperationsDelegate = d;
		}

		[IdlName("create_mutex")]
		public override RTCORBA.IMutex CreateMutex()
		{
			return _OperationsDelegate.CreateMutex();
		}
		[IdlName("destroy_mutex")]
		public override void DestroyMutex(RTCORBA.IMutex theMutex)
		{
			_OperationsDelegate.DestroyMutex(theMutex);
		}
		[IdlName("create_threadpool")]
		public override uint CreateThreadpool(uint stacksize, uint staticThreads, uint dynamicThreads, short defaultPriority, bool allowRequestBuffering, uint maxBufferedRequests, uint maxRequestBufferSize)
		{
			return _OperationsDelegate.CreateThreadpool(stacksize, staticThreads, dynamicThreads, defaultPriority, allowRequestBuffering, maxBufferedRequests, maxRequestBufferSize);
		}
		[IdlName("create_threadpool_with_lanes")]
		public override uint CreateThreadpoolWithLanes(uint stacksize, RTCORBA.ThreadpoolLane[] lanes, bool allowBorrowing, bool allowRequestBuffering, uint maxBufferedRequests, uint maxRequestBufferSize)
		{
			return _OperationsDelegate.CreateThreadpoolWithLanes(stacksize, lanes, allowBorrowing, allowRequestBuffering, maxBufferedRequests, maxRequestBufferSize);
		}
		[IdlName("destroy_threadpool")]
		[ThrowsIdlException(typeof(RTCORBA.RTORB.InvalidThreadpool))]
		public override void DestroyThreadpool(uint threadpool)
		{
			_OperationsDelegate.DestroyThreadpool(threadpool);
		}
		[IdlName("create_priority_model_policy")]
		public override RTCORBA.IPriorityModelPolicy CreatePriorityModelPolicy(RTCORBA.PriorityModel priorityModel, short serverPriority)
		{
			return _OperationsDelegate.CreatePriorityModelPolicy(priorityModel, serverPriority);
		}
		[IdlName("create_threadpool_policy")]
		public override RTCORBA.IThreadpoolPolicy CreateThreadpoolPolicy(uint threadpool)
		{
			return _OperationsDelegate.CreateThreadpoolPolicy(threadpool);
		}
		[IdlName("create_priority_banded_connection_policy")]
		public override RTCORBA.IPriorityBandedConnectionPolicy CreatePriorityBandedConnectionPolicy(RTCORBA.PriorityBand[] priorityBands)
		{
			return _OperationsDelegate.CreatePriorityBandedConnectionPolicy(priorityBands);
		}
		[IdlName("create_server_protocol_policy")]
		public override RTCORBA.IServerProtocolPolicy CreateServerProtocolPolicy(RTCORBA.Protocol[] protocols)
		{
			return _OperationsDelegate.CreateServerProtocolPolicy(protocols);
		}
		[IdlName("create_client_protocol_policy")]
		public override RTCORBA.IClientProtocolPolicy CreateClientProtocolPolicy(RTCORBA.Protocol[] protocols)
		{
			return _OperationsDelegate.CreateClientProtocolPolicy(protocols);
		}
		[IdlName("create_private_connection_policy")]
		public override RTCORBA.IPrivateConnectionPolicy CreatePrivateConnectionPolicy()
		{
			return _OperationsDelegate.CreatePrivateConnectionPolicy();
		}
		[IdlName("create_tcp_protocol_properties")]
		public override RTCORBA.ITCPProtocolProperties CreateTcpProtocolProperties(int sendBufferSize, int recvBufferSize, bool keepAlive, bool dontRoute, bool noDelay)
		{
			return _OperationsDelegate.CreateTcpProtocolProperties(sendBufferSize, recvBufferSize, keepAlive, dontRoute, noDelay);
		}
	}
}
