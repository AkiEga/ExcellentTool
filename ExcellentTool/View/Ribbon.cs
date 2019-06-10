using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ExcellentTool.View {
    public partial class Ribbon {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e) {

        }

        private void EditBox1_TextChanged(object sender, RibbonControlEventArgs e) {

        }

        private void HorizontalStackBtn_Click(object sender, RibbonControlEventArgs e) {
            float span=0.0f;
            try { 
                span = float.Parse(StackSpanBox.Text);
            } catch { }
            ThisAddIn.StackAutoShapes(StackDirection.Horizontal, span);
        }

        private void VerticalStackBtn_Click(object sender, RibbonControlEventArgs e) {
            float span =0.0f;
            try {
                span = float.Parse(StackSpanBox.Text);
            } catch { }
            ThisAddIn.StackAutoShapes(StackDirection.Vertical, span);
        }

        private void SetWideMarginBtn_Click(object sender, RibbonControlEventArgs e) {
            ThisAddIn.SetMarginWidth(1.0f);
        }

        private void SetNormalMarginBtn_Click(object sender, RibbonControlEventArgs e) {
            ThisAddIn.SetMarginWidth(0.1f);
        }

        private void SetNarrowMarginBtn_Click(object sender, RibbonControlEventArgs e) {
            ThisAddIn.SetMarginWidth(0.05f);
        }
    }
}
