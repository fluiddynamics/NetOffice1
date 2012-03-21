//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SearchFolders 
	/// SupportByVersion Office, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SearchFolders : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.ScopeFolder>
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
                    _type = typeof(SearchFolders);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchFolders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchFolders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchFolders(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchFolders() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchFolders(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.ScopeFolder this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.ScopeFolder newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ScopeFolder.LateBindingApiWrapperType) as NetOffice.OfficeApi.ScopeFolder;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="scopeFolder">NetOffice.OfficeApi.ScopeFolder ScopeFolder</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Add(NetOffice.OfficeApi.ScopeFolder scopeFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scopeFolder);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void Remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.ScopeFolder> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
       public IEnumerator<NetOffice.OfficeApi.ScopeFolder> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.ScopeFolder item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}