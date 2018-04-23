using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace DXSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void OnEditValueChanged(object sender, EventArgs e) {
            treeList1.RootNodeIndent = trackBarControl1.Value;
        }
    }
}




