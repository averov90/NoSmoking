using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Anti_Kurenie.My
{
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public AbountProgramm m_AbountProgramm;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public data m_data;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Events_View m_Events_View;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Komments m_Komments;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public no_smoking m_no_smoking;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public no_smoking_winner m_no_smoking_winner;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public one m_one;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Opros m_Opros;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public phon m_phon;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public PM m_PM;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Results m_Results;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Settings m_Settings;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public start m_start;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Yes m_Yes;

			public AbountProgramm AbountProgramm
			{
				get
				{
					m_AbountProgramm = Create__Instance__(m_AbountProgramm);
					return m_AbountProgramm;
				}
				set
				{
					if (value != m_AbountProgramm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_AbountProgramm);
					}
				}
			}

			public data data
			{
				get
				{
					m_data = Create__Instance__(m_data);
					return m_data;
				}
				set
				{
					if (value != m_data)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_data);
					}
				}
			}

			public Events_View Events_View
			{
				get
				{
					m_Events_View = Create__Instance__(m_Events_View);
					return m_Events_View;
				}
				set
				{
					if (value != m_Events_View)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Events_View);
					}
				}
			}

			public Komments Komments
			{
				get
				{
					m_Komments = Create__Instance__(m_Komments);
					return m_Komments;
				}
				set
				{
					if (value != m_Komments)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Komments);
					}
				}
			}

			public no_smoking no_smoking
			{
				get
				{
					m_no_smoking = Create__Instance__(m_no_smoking);
					return m_no_smoking;
				}
				set
				{
					if (value != m_no_smoking)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_no_smoking);
					}
				}
			}

			public no_smoking_winner no_smoking_winner
			{
				get
				{
					m_no_smoking_winner = Create__Instance__(m_no_smoking_winner);
					return m_no_smoking_winner;
				}
				set
				{
					if (value != m_no_smoking_winner)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_no_smoking_winner);
					}
				}
			}

			public one one
			{
				get
				{
					m_one = Create__Instance__(m_one);
					return m_one;
				}
				set
				{
					if (value != m_one)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_one);
					}
				}
			}

			public Opros Opros
			{
				get
				{
					m_Opros = Create__Instance__(m_Opros);
					return m_Opros;
				}
				set
				{
					if (value != m_Opros)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Opros);
					}
				}
			}

			public phon phon
			{
				get
				{
					m_phon = Create__Instance__(m_phon);
					return m_phon;
				}
				set
				{
					if (value != m_phon)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_phon);
					}
				}
			}

			public PM PM
			{
				get
				{
					m_PM = Create__Instance__(m_PM);
					return m_PM;
				}
				set
				{
					if (value != m_PM)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_PM);
					}
				}
			}

			public Results Results
			{
				get
				{
					m_Results = Create__Instance__(m_Results);
					return m_Results;
				}
				set
				{
					if (value != m_Results)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Results);
					}
				}
			}

			public Settings Settings
			{
				get
				{
					m_Settings = Create__Instance__(m_Settings);
					return m_Settings;
				}
				set
				{
					if (value != m_Settings)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Settings);
					}
				}
			}

			public start start
			{
				get
				{
					m_start = Create__Instance__(m_start);
					return m_start;
				}
				set
				{
					if (value != m_start)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_start);
					}
				}
			}

			public Yes Yes
			{
				get
				{
					m_Yes = Create__Instance__(m_Yes);
					return m_Yes;
				}
				set
				{
					if (value != m_Yes)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Yes);
					}
				}
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (m_FormBeingCreated != null)
					{
						if (m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
						}
					}
					else
					{
						m_FormBeingCreated = new Hashtable();
					}
					m_FormBeingCreated.Add(typeof(T), null);
					TargetInvocationException ex2 = default(TargetInvocationException);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						ProjectData.SetProjectError(ex);
						ex2 = ex;
						return ex2.InnerException != null;
					}).Invoke())
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex2.InnerException.Message), ex2.InnerException);
					}
					finally
					{
						m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = null;
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyWebServices);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}

		private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

		private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

		private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

		private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

		private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
