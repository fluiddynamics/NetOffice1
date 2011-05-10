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
	/// DispatchInterface DiagramNode SupportByLibrary PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP10","PP11","PP12","PP14")]
	public class DiagramNode : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.DiagramNodeChildren Children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Children", paramsArray);
				NetOffice.PowerPointApi.DiagramNodeChildren newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.DiagramNodeChildren;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.DiagramNode Root
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Root", paramsArray);
				NetOffice.PowerPointApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Diagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				NetOffice.PowerPointApi.Diagram newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Diagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Layout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape TextShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextShape", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		/// <param name="NodeType">NetOffice.OfficeApi.Enums.MsoDiagramNodeType NodeType</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.DiagramNode AddNode(NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos, NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pos, nodeType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="TargetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		/// <param name="Pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void MoveNode(NetOffice.PowerPointApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, pos);
			Invoker.Method(this, "MoveNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="TargetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void ReplaceNode(NetOffice.PowerPointApi.DiagramNode targetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode);
			Invoker.Method(this, "ReplaceNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="TargetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		/// <param name="SwapChildren">bool SwapChildren</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void SwapNode(NetOffice.PowerPointApi.DiagramNode targetNode, bool swapChildren)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, swapChildren);
			Invoker.Method(this, "SwapNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="CopyChildren">bool CopyChildren</param>
		/// <param name="TargetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		/// <param name="Pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.DiagramNode CloneNode(bool copyChildren, NetOffice.PowerPointApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(copyChildren, targetNode, pos);
			object returnItem = Invoker.MethodReturn(this, "CloneNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="ReceivingNode">NetOffice.PowerPointApi.DiagramNode ReceivingNode</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void TransferChildren(NetOffice.PowerPointApi.DiagramNode receivingNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(receivingNode);
			Invoker.Method(this, "TransferChildren", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.DiagramNode NextNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.DiagramNode PrevNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PrevNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}