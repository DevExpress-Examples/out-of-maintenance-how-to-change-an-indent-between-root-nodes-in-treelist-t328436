Imports DevExpress.XtraGrid.Views.Grid
Namespace DXSample
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.treeList1 = New DXSample.CustomTreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(109, 12)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(255, 20)
            Me.textEdit1.TabIndex = 4
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.BeginUnboundLoad()
            Me.treeList1.AppendNode(New Object() { "Test1", Nothing}, -1)
            Me.treeList1.AppendNode(New Object() { "Test2", Nothing}, 0)
            Me.treeList1.AppendNode(New Object() { "Test3", Nothing}, 0)
            Me.treeList1.AppendNode(New Object() { "Test4", Nothing}, -1)
            Me.treeList1.AppendNode(New Object() { "Test5", Nothing}, 3)
            Me.treeList1.AppendNode(New Object() { "Test6", Nothing}, 4)
            Me.treeList1.AppendNode(New Object() { "Test7", Nothing}, -1)
            Me.treeList1.AppendNode(New Object() { "Test8", Nothing}, 6)
            Me.treeList1.AppendNode(New Object() { "Test9", Nothing}, 6)
            Me.treeList1.EndUnboundLoad()
            Me.treeList1.OptionsBehavior.AutoNodeHeight = False
            Me.treeList1.RootNodeIndent = 0
            Me.treeList1.Size = New System.Drawing.Size(749, 376)
            Me.treeList1.TabIndex = 0
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Column1"
            Me.treeListColumn1.FieldName = "Column1"
            Me.treeListColumn1.MinWidth = 70
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            ' 
            ' treeListColumn2
            ' 
            Me.treeListColumn2.Caption = "Column2"
            Me.treeListColumn2.FieldName = "Column2"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.trackBarControl1.EditValue = Nothing
            Me.trackBarControl1.Location = New System.Drawing.Point(0, 376)
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl1.Properties.Maximum = 20
            Me.trackBarControl1.Properties.ShowLabels = True
            Me.trackBarControl1.Size = New System.Drawing.Size(749, 45)
            Me.trackBarControl1.TabIndex = 1
            ' 
            ' Main
            ' 
            Me.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(749, 421)
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.trackBarControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Main"
            Me.Text = "Form1"
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private textEdit1 As DevExpress.XtraEditors.TextEdit
        Private treeList1 As CustomTreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
    End Class
End Namespace

