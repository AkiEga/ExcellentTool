using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using ExcellentTool.View;

namespace ExcellentTool {
    public enum StackDirection {
        Vertical,
        Horizontal
    };
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        // set margin width
        public static void SetMarginWidth(double marginWidthCM) {
            foreach (Excel.Shape s in Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange) {
                double convertRatio = (100.0 / 3.53);
                float marginWidth = (float)(marginWidthCM * convertRatio);

                s.TextFrame.MarginRight = marginWidth;
                s.TextFrame.MarginLeft = marginWidth;
                s.TextFrame.MarginTop = marginWidth;
                s.TextFrame.MarginBottom = marginWidth;
            }
        }
        // Alpha Value
        public static void SetAlphaValue(float alphaValue) {
            foreach (Excel.Shape s in Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange) {
                s.Fill.Transparency = alphaValue;
            }
            return;
        }

        // Auto Shape Position
        public static void StackAutoShapes(StackDirection stackDirection, float span) {
            try { 
                if (Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange.Count <= 1) {
                    return;
                }
            } catch { }

            List<Excel.Shape> selectedShapes = new List<Excel.Shape>();
            foreach (Excel.Shape s in Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange) {
                selectedShapes.Add(s);
            }

            if (stackDirection == StackDirection.Horizontal) {
                selectedShapes.Sort((a, b) => a.Left.CompareTo(b.Left));

                for (int i = 1; i < selectedShapes.Count; i++) {
                    var upperShape = selectedShapes[i - 1];
                    selectedShapes[i].Left = upperShape.Left + upperShape.Width + span;
                }
            } else if (stackDirection == StackDirection.Vertical) {
                selectedShapes.Sort((a, b) => a.Top.CompareTo(b.Top));

                for (int i = 1; i < selectedShapes.Count; i++) {
                    var upperShape = selectedShapes[i - 1];
                    selectedShapes[i].Top = upperShape.Top + upperShape.Height + span;
                }
            }
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
