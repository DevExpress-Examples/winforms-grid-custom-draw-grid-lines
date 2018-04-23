using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;
using DevExpress.XtraGrid.Views.Grid;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

        }

        private void myGridView1_CustomDrawGridLine(object sender, CustomDrawLineEventArgs e) {
            if(e.CellInfo != null)
                e.Appearance.BackColor = e.CellInfo.RowHandle % 2 == 0 ? Color.BlueViolet : Color.DarkOrange;
            else {
                HatchBrush brush = new HatchBrush(HatchStyle.Trellis, Color.Green, Color.Yellow);
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Handled = true;
            }
        }
    }
}
