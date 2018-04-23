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
    public class CustomDrawLineEventArgs {
        Graphics graphics;
        bool handled;
        Rectangle bounds;
        GridCellInfo cellInfo;
        AppearanceObject appearance;

        public CustomDrawLineEventArgs(Graphics graphics, AppearanceObject appearance, Rectangle bounds, GridCellInfo cellInfo) {
            this.graphics = graphics;
            this.bounds = bounds;
            this.cellInfo = cellInfo;
            this.appearance = appearance;
        }

        public Graphics Graphics {
            get { return graphics; }
        }

        public AppearanceObject Appearance {
            get { return appearance; }
        }

        public bool Handled {
            get { return handled; }
            set { handled = value; }
        }

        public Rectangle Bounds {
            get { return bounds; }
        }

        public GridCellInfo CellInfo {
            get { return cellInfo; }
        }
    }

    public delegate void CustomDrawLineEventHandler(object sender, CustomDrawLineEventArgs e);
}