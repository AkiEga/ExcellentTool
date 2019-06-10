using System;

namespace ExcellentTool.View {

    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory()) {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.HorizontalStackBtn = this.Factory.CreateRibbonButton();
            this.VerticalStackBtn = this.Factory.CreateRibbonButton();
            this.StackSpanBox = this.Factory.CreateRibbonEditBox();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.splitButton1 = this.Factory.CreateRibbonSplitButton();
            this.SetWideMarginBtn = this.Factory.CreateRibbonButton();
            this.SetNormalMarginBtn = this.Factory.CreateRibbonButton();
            this.SetNarrowMarginBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Excellent";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.HorizontalStackBtn);
            this.group1.Items.Add(this.VerticalStackBtn);
            this.group1.Items.Add(this.StackSpanBox);
            this.group1.Label = "Stack";
            this.group1.Name = "group1";
            // 
            // HorizontalStackBtn
            // 
            this.HorizontalStackBtn.Label = "| | | Horizontal";
            this.HorizontalStackBtn.Name = "HorizontalStackBtn";
            this.HorizontalStackBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.HorizontalStackBtn_Click);
            // 
            // VerticalStackBtn
            // 
            this.VerticalStackBtn.Label = "三  Vertical";
            this.VerticalStackBtn.Name = "VerticalStackBtn";
            this.VerticalStackBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.VerticalStackBtn_Click);
            // 
            // StackSpanBox
            // 
            this.StackSpanBox.Label = "Span [mm]";
            this.StackSpanBox.Name = "StackSpanBox";
            this.StackSpanBox.Text = "0";
            this.StackSpanBox.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EditBox1_TextChanged);
            // 
            // group2
            // 
            this.group2.Items.Add(this.splitButton1);
            this.group2.Label = "Shape";
            this.group2.Name = "group2";
            // 
            // splitButton1
            // 
            this.splitButton1.Items.Add(this.SetWideMarginBtn);
            this.splitButton1.Items.Add(this.SetNormalMarginBtn);
            this.splitButton1.Items.Add(this.SetNarrowMarginBtn);
            this.splitButton1.Label = "Margin";
            this.splitButton1.Name = "splitButton1";
            // 
            // SetWideMarginBtn
            // 
            this.SetWideMarginBtn.Label = "Wide";
            this.SetWideMarginBtn.Name = "SetWideMarginBtn";
            this.SetWideMarginBtn.ShowImage = true;
            this.SetWideMarginBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetWideMarginBtn_Click);
            // 
            // SetNormalMarginBtn
            // 
            this.SetNormalMarginBtn.Label = "Normal";
            this.SetNormalMarginBtn.Name = "SetNormalMarginBtn";
            this.SetNormalMarginBtn.ShowImage = true;
            this.SetNormalMarginBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetNormalMarginBtn_Click);
            // 
            // SetNarrowMarginBtn
            // 
            this.SetNarrowMarginBtn.Label = "Narrow";
            this.SetNarrowMarginBtn.Name = "SetNarrowMarginBtn";
            this.SetNarrowMarginBtn.ShowImage = true;
            this.SetNarrowMarginBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetNarrowMarginBtn_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton VerticalStackBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton HorizontalStackBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox StackSpanBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetWideMarginBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetNormalMarginBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetNarrowMarginBtn;
    }

    partial class ThisRibbonCollection {
        internal Ribbon Ribbon {
            get { return this.GetRibbon<Ribbon>(); }
        }

        private T GetRibbon<T>() {
            throw new NotImplementedException();
        }
    }
}
