//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface OMathFunctions SupportByLibrary WD12 WD14 
	///</summary>
	[SupportByLibrary("WD12","WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class OMathFunctions : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunctions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunctions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunctions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunctions()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("WD12","WD14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.OMathFunction this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.OMathFunction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.OMathFunction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Type">NetOffice.WordApi.Enums.WdOMathFunctionType Type</param>
		/// <param name="NumArgs">ref optional object NumArgs</param>
		/// <param name="NumCols">ref optional object NumCols</param>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.OMathFunction Add(NetOffice.WordApi.Range range, NetOffice.WordApi.Enums.WdOMathFunctionType type, ref object numArgs, ref object numCols)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, type, numArgs, numCols);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.WordApi.OMathFunction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.OMathFunction;
			numArgs = (object)paramsArray[2];
			numCols = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Type">NetOffice.WordApi.Enums.WdOMathFunctionType Type</param>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.OMathFunction Add(NetOffice.WordApi.Range range, NetOffice.WordApi.Enums.WdOMathFunctionType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.OMathFunction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.OMathFunction;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD12","WD14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}