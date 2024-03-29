/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:36
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace MessageRouting
{
	public class _PersistentRequestStub: CORBA.Object, IPersistentRequest
	{
		private new string[] _ids = {"IDL:MessageRouting/PersistentRequest:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		public static Type _opsType = typeof(IPersistentRequestOperations);

		public bool ReplyAvailable
		{
			get
			{
				while(true)
				{
					{
						IInputStream inputStream = null;
						IOutputStream outputStream = null;
						try
						{
							outputStream = _Request("_get_reply_available", true);
							inputStream = _Invoke(outputStream);
							bool _result;
							_result = inputStream.ReadBoolean();
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
			}
		}
		public Messaging.IReplyHandler AssociatedHandler
		{
			get
			{
				while(true)
				{
					{
						IInputStream inputStream = null;
						IOutputStream outputStream = null;
						try
						{
							outputStream = _Request("_get_associated_handler", true);
							inputStream = _Invoke(outputStream);
							Messaging.IReplyHandler _result;
							_result = Messaging.ReplyHandlerHelper.Read(inputStream);
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
			}
			set
			{
				while(true)
				{
					{
						IInputStream inputStream = null;
						IOutputStream outputStream = null;
						try
						{
							outputStream = _Request("_set_associated_handler", true);
							Messaging.ReplyHandlerHelper.Write(outputStream, value);
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
							this._ReleaseReply(inputStream);
						}
					}
				}
			}
		}
		[IdlName("get_reply")]
		[ThrowsIdlException(typeof(MessageRouting.ReplyNotAvailable))]
		public GIOP.ReplyStatusType12 GetReply(bool blocking, uint timeout, out MessageRouting.MessageBody replyBody)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("get_reply", true);
					outputStream.WriteBoolean(blocking);
					outputStream.WriteULong(timeout);
					inputStream = _Invoke(outputStream);
					GIOP.ReplyStatusType12 _result;
					_result = GIOP.ReplyStatusType12Helper.Read(inputStream);
					replyBody = MessageRouting.MessageBodyHelper.Read(inputStream);
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
							case "IDL:MessageRouting/ReplyNotAvailable:1.0":
								throw MessageRouting.ReplyNotAvailableHelper.Read(aex.InputStream);
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
		[IdlName("get_reply_with_context")]
		[ThrowsIdlException(typeof(MessageRouting.ReplyNotAvailable))]
		public GIOP.ReplyStatusType12 GetReplyWithContext(bool blocking, uint timeout, out MessageRouting.MessageBody replyBody, out IOP.ServiceContext[] serviceContexts)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("get_reply_with_context", true);
					outputStream.WriteBoolean(blocking);
					outputStream.WriteULong(timeout);
					inputStream = _Invoke(outputStream);
					GIOP.ReplyStatusType12 _result;
					_result = GIOP.ReplyStatusType12Helper.Read(inputStream);
					replyBody = MessageRouting.MessageBodyHelper.Read(inputStream);
					{
						var _capacity0 = inputStream.ReadLong();
						if (inputStream.Available > 0 && _capacity0 > inputStream.Available)
						{
							throw new Marshal($"Sequence length too large. Only {inputStream.Available} and trying to assign {_capacity0}");
						}
						serviceContexts = new IOP.ServiceContext[_capacity0];
						for (int i0 = 0; i0 < _capacity0; i0++)
						{
							IOP.ServiceContext _item0;
							_item0 = IOP.ServiceContextHelper.Read(inputStream);
							serviceContexts[i0] = _item0;
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
							case "IDL:MessageRouting/ReplyNotAvailable:1.0":
								throw MessageRouting.ReplyNotAvailableHelper.Read(aex.InputStream);
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
