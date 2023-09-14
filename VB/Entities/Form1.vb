Imports System.Data.Objects
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DXSample

    Public Partial Class Form1
        Inherits XtraForm

        Private northwind As NorthwindEntities

        Public Sub New()
            InitializeComponent()
            northwind = New NorthwindEntities()
            Dim productsQuery As ObjectQuery(Of Product) = northwind.Products.Include("Order_Details.Order")
            gridControl1.DataSource = New BindingSource(productsQuery, "")
        End Sub

        Private Sub OnMasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs)
            Dim p As Product = CType(gridView1.GetRow(e.RowHandle), Product)
            e.IsEmpty = p.Order_Details.Count = 0
        End Sub

        Private Sub OnMasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs)
            e.RelationCount = 1
        End Sub

        Private Sub OnMasterRowGetRelationName(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs)
            e.RelationName = "Orders"
        End Sub

        Private Sub OnMasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs)
            Dim p As Product = CType(gridView1.GetRow(e.RowHandle), Product)
            e.ChildList = p.Order_Details.[Select](Function(od) od.Order).Distinct().ToList()
        End Sub
    End Class
End Namespace
