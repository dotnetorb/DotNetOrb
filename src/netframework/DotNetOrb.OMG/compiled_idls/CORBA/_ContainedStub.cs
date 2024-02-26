/**
 * Generated by DotNetORb.IdlCompiler V 1.0.0.0
 * Timestamp: 25/02/2024 9:49:27
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CORBA;


namespace CORBA
{
	public class _ContainedStub: CORBA.Object, IContained
	{
		private new string[] _ids = {"IDL:CORBA/Contained:1.0","IDL:CORBA/IRObject:1.0"};

		public override string[] _Ids()
		{
			return _ids;
		}

		public static Type _opsType = typeof(IContainedOperations);

		public CORBA.DefinitionKind DefKind
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
							outputStream = _Request("_get_def_kind", true);
							inputStream = _Invoke(outputStream);
							CORBA.DefinitionKind _result;
							_result = CORBA.DefinitionKindHelper.Read(inputStream);
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
		[WideChar(false)]
		public string Id
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
							outputStream = _Request("_get_id", true);
							inputStream = _Invoke(outputStream);
							string _result;
							_result = inputStream.ReadString();
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
							outputStream = _Request("_set_id", true);
							outputStream.WriteString(value);
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
		[WideChar(false)]
		public string Name
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
							outputStream = _Request("_get_name", true);
							inputStream = _Invoke(outputStream);
							string _result;
							_result = inputStream.ReadString();
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
							outputStream = _Request("_set_name", true);
							outputStream.WriteString(value);
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
		[WideChar(false)]
		public string Version
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
							outputStream = _Request("_get_version", true);
							inputStream = _Invoke(outputStream);
							string _result;
							_result = inputStream.ReadString();
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
							outputStream = _Request("_set_version", true);
							outputStream.WriteString(value);
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
		public CORBA.IContainer DefinedIn
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
							outputStream = _Request("_get_defined_in", true);
							inputStream = _Invoke(outputStream);
							CORBA.IContainer _result;
							_result = CORBA.ContainerHelper.Read(inputStream);
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
		[WideChar(false)]
		public string AbsoluteName
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
							outputStream = _Request("_get_absolute_name", true);
							inputStream = _Invoke(outputStream);
							string _result;
							_result = inputStream.ReadString();
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
		public CORBA.IRepository ContainingRepository
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
							outputStream = _Request("_get_containing_repository", true);
							inputStream = _Invoke(outputStream);
							CORBA.IRepository _result;
							_result = CORBA.RepositoryHelper.Read(inputStream);
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
		[IdlName("describe")]
		public CORBA.Contained.Description Describe()
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("describe", true);
					inputStream = _Invoke(outputStream);
					CORBA.Contained.Description _result;
					_result = CORBA.Contained.DescriptionHelper.Read(inputStream);
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
		[IdlName("move")]
		public void Move(CORBA.IContainer newContainer, [WideChar(false)] string newName, [WideChar(false)] string newVersion)
		{
			while(true)
			{
				IInputStream inputStream = null;
				IOutputStream outputStream = null;
				try
				{
					outputStream = _Request("move", true);
					CORBA.ContainerHelper.Write(outputStream, newContainer);
					outputStream.WriteString(newName);
					outputStream.WriteString(newVersion);
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
