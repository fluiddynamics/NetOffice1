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
	/// DispatchInterface _Conversation 
	/// SupportByVersion Outlook, 14
	///</summary>
	[SupportByVersionAttribute("Outlook", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Conversation : COMObject
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
                    _type = typeof(_Conversation);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
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
		/// SupportByVersion Outlook 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
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
		/// SupportByVersion Outlook 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
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
		/// SupportByVersion Outlook 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
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
		/// SupportByVersion Outlook 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public string ConversationID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public NetOffice.OutlookApi.Table GetTable()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetTable", paramsArray);
			NetOffice.OutlookApi.Table newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.Table.LateBindingApiWrapperType) as NetOffice.OutlookApi.Table;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="item">object Item</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public NetOffice.OutlookApi.SimpleItems GetChildren(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.MethodReturn(this, "GetChildren", paramsArray);
			NetOffice.OutlookApi.SimpleItems newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.SimpleItems.LateBindingApiWrapperType) as NetOffice.OutlookApi.SimpleItems;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="item">object Item</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public object GetParent(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.MethodReturn(this, "GetParent", paramsArray);
			object newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public NetOffice.OutlookApi.SimpleItems GetRootItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetRootItems", paramsArray);
			NetOffice.OutlookApi.SimpleItems newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.SimpleItems.LateBindingApiWrapperType) as NetOffice.OutlookApi.SimpleItems;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public string GetAlwaysAssignCategories(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			object returnItem = Invoker.MethodReturn(this, "GetAlwaysAssignCategories", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation GetAlwaysDelete(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			object returnItem = Invoker.MethodReturn(this, "GetAlwaysDelete", paramsArray);
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation)intReturnItem;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public NetOffice.OutlookApi.MAPIFolder GetAlwaysMoveToFolder(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			object returnItem = Invoker.MethodReturn(this, "GetAlwaysMoveToFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public void MarkAsRead()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MarkAsRead", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 14)]
		public void MarkAsUnread()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MarkAsUnread", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="categories">string Categories</param>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public void SetAlwaysAssignCategories(string categories, NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(categories, store);
			Invoker.Method(this, "SetAlwaysAssignCategories", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="alwaysDelete">NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation AlwaysDelete</param>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public void SetAlwaysDelete(NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation alwaysDelete, NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(alwaysDelete, store);
			Invoker.Method(this, "SetAlwaysDelete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="moveToFolder">NetOffice.OutlookApi.MAPIFolder MoveToFolder</param>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public void SetAlwaysMoveToFolder(NetOffice.OutlookApi.MAPIFolder moveToFolder, NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(moveToFolder, store);
			Invoker.Method(this, "SetAlwaysMoveToFolder", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public void ClearAlwaysAssignCategories(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "ClearAlwaysAssignCategories", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public void StopAlwaysDelete(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "StopAlwaysDelete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		/// <param name="store">NetOffice.OutlookApi._Store Store</param>
		[SupportByVersionAttribute("Outlook", 14)]
		public void StopAlwaysMoveToFolder(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "StopAlwaysMoveToFolder", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}