using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface FormDescription 
	/// SupportByVersion Outlook, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FormDescription : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(FormDescription);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormDescription(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormDescription(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormDescription(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormDescription() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormDescription(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Category
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Category", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Category", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string CategorySub
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CategorySub", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CategorySub", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Comment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comment", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ContactName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContactName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ContactName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool Hidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hidden", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Hidden", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Icon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Icon", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Icon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool Locked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Locked", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Locked", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MessageClass
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MessageClass", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string MiniIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MiniIcon", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MiniIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Number
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Number", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Number", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool OneOff
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OneOff", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OneOff", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Password
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Password", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Password", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string ScriptText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScriptText", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Template
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Template", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Template", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public bool UseWordMail
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseWordMail", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseWordMail", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Version", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="registry">NetOffice.OutlookApi.Enums.OlFormRegistry Registry</param>
		/// <param name="folder">optional object Folder</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void PublishForm(NetOffice.OutlookApi.Enums.OlFormRegistry registry, object folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(registry, folder);
			Invoker.Method(this, "PublishForm", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="registry">NetOffice.OutlookApi.Enums.OlFormRegistry Registry</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void PublishForm(NetOffice.OutlookApi.Enums.OlFormRegistry registry)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(registry);
			Invoker.Method(this, "PublishForm", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}