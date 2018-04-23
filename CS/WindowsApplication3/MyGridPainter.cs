using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace DXSample {
    public class MyGridPainter: GridPainter {
        public MyGridPainter(GridView view) : base(view) { }
        protected override void DrawLine(ViewDrawArgs e, IndentInfo indent) {
            if(!IsAllowDrawIndent(indent)) return;

            CustomDrawLineEventArgs args;
            CellIndentInfo cellIndentInfo = indent as CellIndentInfo;
            if(cellIndentInfo == null)
                args = new CustomDrawLineEventArgs(e.Cache, indent.Appearance, indent.Bounds, null);
            else
                args = new CustomDrawLineEventArgs(e.Cache, indent.Appearance, indent.Bounds, cellIndentInfo.Cell);

            View.RaiseCustomDrawGridLine(args);
            if(args.Handled) return;
            base.DrawLine(e, indent);
        }

        public new MyGridView View {
            get { return base.View as MyGridView; }
        }
    }
}

