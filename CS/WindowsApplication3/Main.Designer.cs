using DevExpress.XtraGrid.Views.Grid;
namespace DXSample {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.treeList1 = new DXSample.CustomTreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(109, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(255, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Test1",
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "Test2",
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            "Test3",
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            "Test4",
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "Test5",
            null}, 3);
            this.treeList1.AppendNode(new object[] {
            "Test6",
            null}, 4);
            this.treeList1.AppendNode(new object[] {
            "Test7",
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "Test8",
            null}, 6);
            this.treeList1.AppendNode(new object[] {
            "Test9",
            null}, 6);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsBehavior.AutoNodeHeight = false;
            this.treeList1.RootNodeIndent = 0;
            this.treeList1.Size = new System.Drawing.Size(749, 376);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Column1";
            this.treeListColumn1.FieldName = "Column1";
            this.treeListColumn1.MinWidth = 70;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Column2";
            this.treeListColumn2.FieldName = "Column2";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarControl1.EditValue = null;
            this.trackBarControl1.Location = new System.Drawing.Point(0, 376);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarControl1.Properties.Maximum = 20;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Size = new System.Drawing.Size(749, 45);
            this.trackBarControl1.TabIndex = 1;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.OnEditValueChanged);
            // 
            // Main
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 421);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.trackBarControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private CustomTreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
    }
}

