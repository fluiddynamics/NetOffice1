//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IDOMMouseEvent SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IDOMMouseEvent : COMObject
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
                    _type = typeof(IDOMMouseEvent);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseEvent(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseEvent(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseEvent(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseEvent() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDOMMouseEvent(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 screenX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screenX", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 screenY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screenY", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 clientX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clientX", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 clientY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clientY", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ctrlKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ctrlKey", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool shiftKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shiftKey", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool altKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "altKey", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool metaKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "metaKey", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int16 button
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "button", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IEventTarget relatedTarget
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "relatedTarget", paramsArray);
				LateBindingApi.MSHTMLApi.IEventTarget newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IEventTarget;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int16 buttons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "buttons", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement fromElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "fromElement", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement toElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "toElement", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 x
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "x", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 y
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "y", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetX", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetY", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 pageX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "pageX", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 pageY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "pageY", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 layerX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "layerX", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 layerY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "layerY", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int16 which
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "which", paramsArray);
				return (Int16)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="eventType">string eventType</param>
		/// <param name="canBubble">bool canBubble</param>
		/// <param name="cancelable">bool cancelable</param>
		/// <param name="viewArg">LateBindingApi.MSHTMLApi.IHTMLWindow2 viewArg</param>
		/// <param name="detailArg">Int32 detailArg</param>
		/// <param name="screenXArg">Int32 screenXArg</param>
		/// <param name="screenYArg">Int32 screenYArg</param>
		/// <param name="clientXArg">Int32 clientXArg</param>
		/// <param name="clientYArg">Int32 clientYArg</param>
		/// <param name="ctrlKeyArg">bool ctrlKeyArg</param>
		/// <param name="altKeyArg">bool altKeyArg</param>
		/// <param name="shiftKeyArg">bool shiftKeyArg</param>
		/// <param name="metaKeyArg">bool metaKeyArg</param>
		/// <param name="buttonArg">Int16 buttonArg</param>
		/// <param name="relatedTargetArg">LateBindingApi.MSHTMLApi.IEventTarget relatedTargetArg</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void initMouseEvent(string eventType, bool canBubble, bool cancelable, LateBindingApi.MSHTMLApi.IHTMLWindow2 viewArg, Int32 detailArg, Int32 screenXArg, Int32 screenYArg, Int32 clientXArg, Int32 clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, Int16 buttonArg, LateBindingApi.MSHTMLApi.IEventTarget relatedTargetArg)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
			Invoker.Method(this, "initMouseEvent", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="keyArg">string keyArg</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool getModifierState(string keyArg)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keyArg);
			object returnItem = Invoker.MethodReturn(this, "getModifierState", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}