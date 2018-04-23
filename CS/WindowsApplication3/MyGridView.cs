using System;

namespace DXSample {
	public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {

        public event CustomDrawLineEventHandler CustomDrawGridLine;

		public MyGridView() : this(null) {}
		public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) {
			// put your initialization code here
		}
		protected override string ViewName { get { return "MyGridView"; } }

        internal void RaiseCustomDrawGridLine(CustomDrawLineEventArgs e){
            if(CustomDrawGridLine != null)
                CustomDrawGridLine(this, e);
        }
	}
}
