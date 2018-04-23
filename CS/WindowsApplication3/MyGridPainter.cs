using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using System.Drawing;
using DevExpress.Utils;

namespace DXSample {
    public class MyGridPainter: GridPainter {
        public MyGridPainter(GridView view) : base(view) { }
        protected override void DrawLine(ViewDrawArgs e, IndentInfo indent) {
            if(!IsAllowDrawIndent(indent)) return;
            CustomDrawLineEventArgs args = new CustomDrawLineEventArgs(e.Graphics, indent.Appearance, indent.Bounds, indent.IndentOwner as GridCellInfo);
            View.RaiseCustomDrawGridLine(args);
            if(args.Handled) return;
            base.DrawLine(e, indent);
        }

        public new MyGridView View {
            get { return base.View as MyGridView; }
        }
    }
}

