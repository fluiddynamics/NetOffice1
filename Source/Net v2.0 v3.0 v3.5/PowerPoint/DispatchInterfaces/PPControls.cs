//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPControls SupportByLibrary PP09 
	///</summary>
	[SupportByLibrary("PP09")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPControls : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPControls(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPControls(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPControls(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPControls()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		[SupportByLibrary("PP09")]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("PP09")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.PPControl this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.PPControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPControl;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPPushButton AddPushButton(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPushButton", paramsArray);
			NetOffice.PowerPointApi.PPPushButton newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPPushButton;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPToggleButton AddToggleButton(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddToggleButton", paramsArray);
			NetOffice.PowerPointApi.PPToggleButton newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPToggleButton;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPBitmapButton AddBitmapButton(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddBitmapButton", paramsArray);
			NetOffice.PowerPointApi.PPBitmapButton newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPBitmapButton;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPListBox AddListBox(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddListBox", paramsArray);
			NetOffice.PowerPointApi.PPListBox newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPListBox;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPCheckBox AddCheckBox(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCheckBox", paramsArray);
			NetOffice.PowerPointApi.PPCheckBox newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPCheckBox;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPRadioCluster AddRadioCluster(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddRadioCluster", paramsArray);
			NetOffice.PowerPointApi.PPRadioCluster newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPRadioCluster;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPStaticText AddStaticText(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddStaticText", paramsArray);
			NetOffice.PowerPointApi.PPStaticText newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPStaticText;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		/// <param name="VerticalScrollBar">optional object VerticalScrollBar</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPEditText AddEditText(Single left, Single top, Single width, Single height, object verticalScrollBar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, verticalScrollBar);
			object returnItem = Invoker.MethodReturn(this, "AddEditText", paramsArray);
			NetOffice.PowerPointApi.PPEditText newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPEditText;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPEditText AddEditText(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddEditText", paramsArray);
			NetOffice.PowerPointApi.PPEditText newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPEditText;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPIcon AddIcon(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddIcon", paramsArray);
			NetOffice.PowerPointApi.PPIcon newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPIcon;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPBitmap AddBitmap(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddBitmap", paramsArray);
			NetOffice.PowerPointApi.PPBitmap newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPBitmap;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPSpinner AddSpinner(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddSpinner", paramsArray);
			NetOffice.PowerPointApi.PPSpinner newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPSpinner;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Style">NetOffice.PowerPointApi.Enums.PpScrollBarStyle Style</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPScrollBar AddScrollBar(NetOffice.PowerPointApi.Enums.PpScrollBarStyle style, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(style, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddScrollBar", paramsArray);
			NetOffice.PowerPointApi.PPScrollBar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPScrollBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPGroupBox AddGroupBox(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddGroupBox", paramsArray);
			NetOffice.PowerPointApi.PPGroupBox newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPGroupBox;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPDropDown AddDropDown(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddDropDown", paramsArray);
			NetOffice.PowerPointApi.PPDropDown newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPDropDown;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPDropDownEdit AddDropDownEdit(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddDropDownEdit", paramsArray);
			NetOffice.PowerPointApi.PPDropDownEdit newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPDropDownEdit;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPSlideMiniature AddMiniature(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMiniature", paramsArray);
			NetOffice.PowerPointApi.PPSlideMiniature newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPSlideMiniature;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09")]
		public NetOffice.PowerPointApi.PPFrame AddFrame(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddFrame", paramsArray);
			NetOffice.PowerPointApi.PPFrame newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPFrame;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}