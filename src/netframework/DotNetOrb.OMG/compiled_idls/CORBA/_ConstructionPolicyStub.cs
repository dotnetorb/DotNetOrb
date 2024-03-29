/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:26
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public class _ConstructionPolicyStub: CORBA.Object, IConstructionPolicy
	{
		private new string[] _ids = {"IDL:CORBA/ConstructionPolicy:1.0","IDL:CORBA/Policy:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		public static Type _opsType = typeof(IConstructionPolicyOperations);

		public uint PolicyType
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
							outputStream = _Request("_get_policy_type", true);
							inputStream = _Invoke(outputStream);
							uint _result;
							_result = inputStream.ReadULong();
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
		[IdlName("copy")]
		public CORBA.IPolicy Copy()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("copy", true);
					inputStream = _Invoke(outputStream);
					CORBA.IPolicy _result;
					_result = CORBA.PolicyHelper.Read(inputStream);
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
		[IdlName("destroy")]
		public void Destroy()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("destroy", true);
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
		[IdlName("make_domain_manager")]
		public void MakeDomainManager(CORBA.IInterfaceDef objectType, bool constrPolicy)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("make_domain_manager", true);
					CORBA.InterfaceDefHelper.Write(outputStream, objectType);
					outputStream.WriteBoolean(constrPolicy);
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

	}

}
