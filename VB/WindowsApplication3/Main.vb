Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarControl1.EditValueChanged
            treeList1.RootNodeIndent = trackBarControl1.Value
        End Sub
    End Class
End Namespace




