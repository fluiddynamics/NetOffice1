using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Report_OpenEventHandler(ref Int16 Cancel);
	public delegate void Report_CloseEventHandler();
	public delegate void Report_ActivateEventHandler();
	public delegate void Report_DeactivateEventHandler();
	public delegate void Report_ErrorEventHandler(ref Int16 DataErr, ref Int16 Response);
	public delegate void Report_NoDataEventHandler(ref Int16 Cancel);
	public delegate void Report_PageEventHandler();
	public delegate void Report_CurrentEventHandler();
	public delegate void Report_LoadEventHandler();
	public delegate void Report_ResizeEventHandler();
	public delegate void Report_UnloadEventHandler(ref Int16 Cancel);
	public delegate void Report_GotFocusEventHandler();
	public delegate void Report_LostFocusEventHandler();
	public delegate void Report_ClickEventHandler();
	public delegate void Report_DblClickEventHandler(ref Int16 Cancel);
	public delegate void Report_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Report_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Report_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Report_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void Report_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void Report_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void Report_TimerEventHandler();
	public delegate void Report_FilterEventHandler(ref Int16 Cancel, ref Int16 FilterType);
	public delegate void Report_ApplyFilterEventHandler(ref Int16 Cancel, ref Int16 ApplyType);
	public delegate void Report_MouseWheelEventHandler(bool Page, Int32 Count);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Report 
	/// SupportByVersion Access, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Report : _Report3,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_ReportEvents_SinkHelper __ReportEvents_SinkHelper;
		_ReportEvents2_SinkHelper __ReportEvents2_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Report);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Report(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Report(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Report(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Report 
        /// </summary>		
		public Report():base("Access.Report")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Report
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Report(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_ErrorEventHandler _ErrorEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_ErrorEventHandler ErrorEvent
		{
			add
			{
				CreateEventBridge();
				_ErrorEvent += value;
			}
			remove
			{
				_ErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_NoDataEventHandler _NoDataEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_NoDataEventHandler NoDataEvent
		{
			add
			{
				CreateEventBridge();
				_NoDataEvent += value;
			}
			remove
			{
				_NoDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14
		/// </summary>
		private event Report_PageEventHandler _PageEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14)]
		public event Report_PageEventHandler PageEvent
		{
			add
			{
				CreateEventBridge();
				_PageEvent += value;
			}
			remove
			{
				_PageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_CurrentEventHandler _CurrentEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_CurrentEventHandler CurrentEvent
		{
			add
			{
				CreateEventBridge();
				_CurrentEvent += value;
			}
			remove
			{
				_CurrentEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_LoadEventHandler _LoadEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_LoadEventHandler LoadEvent
		{
			add
			{
				CreateEventBridge();
				_LoadEvent += value;
			}
			remove
			{
				_LoadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_ResizeEventHandler _ResizeEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_ResizeEventHandler ResizeEvent
		{
			add
			{
				CreateEventBridge();
				_ResizeEvent += value;
			}
			remove
			{
				_ResizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_TimerEventHandler _TimerEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_TimerEventHandler TimerEvent
		{
			add
			{
				CreateEventBridge();
				_TimerEvent += value;
			}
			remove
			{
				_TimerEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_FilterEventHandler _FilterEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_FilterEventHandler FilterEvent
		{
			add
			{
				CreateEventBridge();
				_FilterEvent += value;
			}
			remove
			{
				_FilterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_ApplyFilterEventHandler _ApplyFilterEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_ApplyFilterEventHandler ApplyFilterEvent
		{
			add
			{
				CreateEventBridge();
				_ApplyFilterEvent += value;
			}
			remove
			{
				_ApplyFilterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14
		/// </summary>
		private event Report_MouseWheelEventHandler _MouseWheelEvent;

		/// <summary>
		/// SupportByVersion Access 12 14
		/// </summary>
		[SupportByVersion("Access", 12,14)]
		public event Report_MouseWheelEventHandler MouseWheelEvent
		{
			add
			{
				CreateEventBridge();
				_MouseWheelEvent += value;
			}
			remove
			{
				_MouseWheelEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _ReportEvents_SinkHelper.Id,_ReportEvents2_SinkHelper.Id);


			if(_ReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__ReportEvents_SinkHelper = new _ReportEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(_ReportEvents2_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__ReportEvents2_SinkHelper = new _ReportEvents2_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != __ReportEvents_SinkHelper)
			{
				__ReportEvents_SinkHelper.Dispose();
				__ReportEvents_SinkHelper = null;
			}
			if( null != __ReportEvents2_SinkHelper)
			{
				__ReportEvents2_SinkHelper.Dispose();
				__ReportEvents2_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}