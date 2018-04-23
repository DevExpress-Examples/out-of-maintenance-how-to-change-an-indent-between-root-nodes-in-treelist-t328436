Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Internal
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations
Imports DevExpress.XtraTreeList.ViewInfo

Namespace DXSample
    Public Class CustomTreeList
        Inherits TreeList

        Public Sub New()
            Me.OptionsView.ShowIndicator = False
            Me.OptionsView.ShowVertLines = False
            Me.OptionsView.ShowHorzLines = False
            Me.OptionsBehavior.Editable = False
        End Sub
        Protected Sub New(ByVal ignore As Object)
            MyBase.New(ignore)

        End Sub
        Protected Overrides Function CreateViewInfo() As TreeListViewInfo
            Return New CustomTreeListViewInfo(Me)
        End Function
        Friend Shadows ReadOnly Property TopVisibleNode() As TreeListNode
            Get
                Return MyBase.TopVisibleNode
            End Get
        End Property
        Private indent As Integer = 0
        Public Property RootNodeIndent() As Integer
            Get
                Return indent
            End Get
            Set(ByVal value As Integer)
                If indent <> value Then
                    If value < 0 Then
                        value = 0
                    End If
                    If value > 20 Then
                        value = 20
                    End If
                    indent = value
                    OnProperyChanged()
                    LayoutChanged()
                End If
            End Set
        End Property
    End Class
    Public Class CustomTreeListViewInfo
        Inherits TreeListViewInfo

        Public Sub New(ByVal treeList As TreeList)
            MyBase.New(treeList)

        End Sub
        Protected Overrides Sub CalcRowGroupInfo(ByVal nodes As DevExpress.XtraTreeList.Nodes.TreeListNodes, ByVal rowArgs As CalcRowGroupInfoArgs)
            rowArgs.Index = TreeList.TopVisibleNodeIndex
            Dim node As TreeListNode = TreeList.TopVisibleNode
            If Not TreeListFilterHelper.IsNodeVisible(node) Then
                node = TreeListNodesIterator.GetNextVisible(node)
            End If
            Do While node IsNot Nothing AndAlso rowArgs.Bounds.Top < ViewRects.Rows.Bottom
                Dim viewInfoList As ArrayList = Nothing
                Dim ri As RowInfo = CreateRowInfo(node)
                ri.VisibleIndex = rowArgs.Index
                ri.Level = TreeListFilterHelper.CalcVisibleNodeLevel(ri.Node)
                ri.Expanded = ri.Node.Expanded
                UpdateRowCondition(ri)
                ri.NodeHeight = CalcNodeHeight(ri, viewInfoList)
                rowArgs.InflateBoundsHeight(ri.NodeHeight - RowHeight)
                Dim rect As Rectangle = rowArgs.Bounds
                If CanAddIndent(ri) Then
                    rect.Y += TreeList.RootNodeIndent
                End If
                ri.Bounds = rect
                CalcRowInfo(ri, viewInfoList)
                RowsInfo.Rows.Add(ri)
                If CanAddIndent(ri) Then
                    rowArgs.VertOffsetBounds(ri.Bounds.Height + TreeList.RootNodeIndent)
                Else
                    rowArgs.VertOffsetBounds(ri.Bounds.Height)
                End If
                CalcRowFooterInfoEx(node, rowArgs)
                rowArgs.IncIndex()
                node = TreeListNodesIterator.GetNextVisible(node)
            Loop
            RemoveInvisibleAnimatedItems()

        End Sub
        Private Sub CalcRowFooterInfoEx(ByVal node As TreeListNode, ByVal rowArgs As CalcRowGroupInfoArgs)
            Dim fi As FieldInfo = node.GetType().GetField("owner", BindingFlags.Instance Or BindingFlags.NonPublic)
            Dim owner As TreeListNodes = TryCast(fi.GetValue(node), TreeListNodes)
            Dim pr As PropertyInfo = owner.GetType().GetProperty("LastNodeEx", BindingFlags.Instance Or BindingFlags.NonPublic)
            Dim lastNode As TreeListNode = TryCast(pr.GetValue(owner, Nothing), TreeListNode)
            If node Is lastNode Then
                If Not (TreeListFilterHelper.HasVisibleChildren(node) AndAlso node.Expanded) Then
                    Dim even As Boolean = IsEven(rowArgs.Index)
                    CalcRowFooterInfo(RowsInfo.Rows.Count - 1, node, rowArgs, even)
                    Dim parent As TreeListNode = node.ParentNode
                    If parent IsNot Nothing Then
                        owner = TryCast(fi.GetValue(parent), TreeListNodes)
                        lastNode = TryCast(pr.GetValue(owner, Nothing), TreeListNode)
                    End If
                    Do While parent IsNot Nothing AndAlso parent Is lastNode
                        even = Not even
                        CalcRowFooterInfo(RowsInfo.Rows.Count - 1, parent, rowArgs, even)
                        node = parent
                        parent = parent.ParentNode
                        If parent IsNot Nothing Then
                            owner = TryCast(fi.GetValue(parent), TreeListNodes)
                            lastNode = TryCast(pr.GetValue(owner, Nothing), TreeListNode)
                        End If
                    Loop
                End If
            End If
        End Sub
        Private Function IsEven(ByVal value As Integer) As Boolean
            Return (value Mod 2 <> 0)
        End Function
        Private Function CanAddIndent(ByVal ri As RowInfo) As Boolean
            Return ri.Level = 0 AndAlso ri.Node.TreeList.Nodes.IndexOf(ri.Node) <> 0
        End Function
        Private Shadows ReadOnly Property TreeList() As CustomTreeList
            Get
                Return TryCast(MyBase.TreeList, CustomTreeList)
            End Get
        End Property
    End Class
End Namespace
