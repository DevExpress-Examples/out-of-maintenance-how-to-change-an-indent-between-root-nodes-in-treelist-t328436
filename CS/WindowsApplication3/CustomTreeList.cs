using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Internal;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.ViewInfo;

namespace DXSample {
    public class CustomTreeList : TreeList {
        public CustomTreeList() {
            this.OptionsView.ShowIndicator = false;
            this.OptionsView.ShowVertLines = false;
            this.OptionsView.ShowHorzLines = false;
            this.OptionsBehavior.Editable = false;
        }
        protected CustomTreeList(object ignore)
            : base(ignore) {

        }
        protected override TreeListViewInfo CreateViewInfo() {
            return new CustomTreeListViewInfo(this);
        }
        internal new TreeListNode TopVisibleNode {
            get { return base.TopVisibleNode; }
        }
        int indent = 0;
        public int RootNodeIndent {
            get { return indent; }
            set {
                if (indent != value) {
                    if (value < 0)
                        value = 0;
                    if (value > 20)
                        value = 20;
                    indent = value;
                    OnPropertyChanged();                  
                    LayoutChanged();
                }
            }
        }
    }
    public class CustomTreeListViewInfo : TreeListViewInfo {
        public CustomTreeListViewInfo(TreeList treeList)
            : base(treeList) {

        }
        protected override void CalcRowGroupInfo(DevExpress.XtraTreeList.Nodes.TreeListNodes nodes, CalcRowGroupInfoArgs rowArgs) {
            rowArgs.Index = TreeList.TopVisibleNodeIndex;
            TreeListNode node = TreeList.TopVisibleNode;
            if (!TreeListFilterHelper.IsNodeVisible(node)) {
                node = TreeListNodesIterator.GetNextVisible(node);
            }
            while (node != null && rowArgs.Bounds.Top < ViewRects.Rows.Bottom) {
                ArrayList viewInfoList = null;
                RowInfo ri = CreateRowInfo(node);
                ri.VisibleIndex = rowArgs.Index;
                ri.Level = TreeListFilterHelper.CalcVisibleNodeLevel(ri.Node);
                ri.Expanded = ri.Node.Expanded;
                UpdateRowCondition(ri);
                ri.NodeHeight = CalcNodeHeight(ri, out viewInfoList);
                rowArgs.InflateBoundsHeight(ri.NodeHeight - RowHeight);
                Rectangle rect = rowArgs.Bounds;
                if (CanAddIndent(ri))
                    rect.Y += TreeList.RootNodeIndent;
                ri.Bounds = rect;
                CalcRowInfo(ri, viewInfoList);
                RowsInfo.Rows.Add(ri);
                if (CanAddIndent(ri))
                    rowArgs.VertOffsetBounds(ri.Bounds.Height + TreeList.RootNodeIndent);
                else
                    rowArgs.VertOffsetBounds(ri.Bounds.Height);
                CalcRowFooterInfo(node, rowArgs);
                rowArgs.IncIndex();
                node = TreeListNodesIterator.GetNextVisible(node);
            }
            RemoveInvisibleAnimatedItems();
        }
        void CalcRowFooterInfo(TreeListNode node, CalcRowGroupInfoArgs rowArgs) {
            FieldInfo fi = node.GetType().GetField("owner", BindingFlags.Instance | BindingFlags.NonPublic);
            TreeListNodes owner = fi.GetValue(node) as TreeListNodes;
            PropertyInfo pr = owner.GetType().GetProperty("LastNodeEx", BindingFlags.Instance | BindingFlags.NonPublic);
            TreeListNode lastNode = pr.GetValue(owner, null) as TreeListNode;
            if (node == lastNode) {
                if (!(TreeListFilterHelper.HasVisibleChildren(node) && node.Expanded)) {
                    bool even = IsEven(rowArgs.Index);
                    CalcRowFooterInfo(RowsInfo.Rows.Count - 1, node, rowArgs, even);
                    TreeListNode parent = node.ParentNode;
                    if (parent != null) {
                        owner = fi.GetValue(parent) as TreeListNodes;
                        lastNode = pr.GetValue(owner, null) as TreeListNode;
                    }
                    while (parent != null && parent == lastNode) {
                        even = !even;
                        CalcRowFooterInfo(RowsInfo.Rows.Count - 1, parent, rowArgs, even);
                        node = parent;
                        parent = parent.ParentNode;
                        if (parent != null) {
                            owner = fi.GetValue(parent) as TreeListNodes;
                            lastNode = pr.GetValue(owner, null) as TreeListNode;
                        }
                    }
                }
            }
        }
        bool IsEven(int value) { return (value % 2 != 0); }
        bool CanAddIndent(RowInfo ri) {
            return ri.Level == 0 && ri.Node.TreeList.Nodes.IndexOf(ri.Node) != 0;
        }
        new CustomTreeList TreeList {
            get { return base.TreeList as CustomTreeList; }
        }
    }
}
