using System;
using System.Linq;
using System.Data.Objects;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXSample {
    public partial class Form1 : XtraForm {
        NorthwindEntities northwind;
        public Form1() {
            InitializeComponent();
            northwind = new NorthwindEntities();
            ObjectQuery<Product> productsQuery = northwind.Products.Include("Order_Details.Order");
            gridControl1.DataSource = new BindingSource(productsQuery, "");
        }

        private void OnMasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            Product p = (Product)gridView1.GetRow(e.RowHandle);
            e.IsEmpty = p.Order_Details.Count == 0;
        }

        private void OnMasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private void OnMasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Orders";
        }

        private void OnMasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            Product p = (Product)gridView1.GetRow(e.RowHandle);
            e.ChildList = p.Order_Details.Select(od => od.Order).Distinct().ToList(); ;
        }
    }
}
