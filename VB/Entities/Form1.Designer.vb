Namespace DXSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowGroupPanel = False
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "OrderID"
            Me.gridColumn1.FieldName = "OrderID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Freight"
            Me.gridColumn2.FieldName = "Freight"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
            gridLevelNode1.LevelTemplate = Me.gridView2
            gridLevelNode1.RelationName = "Orders"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(1025, 614)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            AddHandler Me.gridView1.MasterRowEmpty, New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(AddressOf Me.OnMasterRowEmpty)
            AddHandler Me.gridView1.MasterRowGetChildList, New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(AddressOf Me.OnMasterRowGetChildList)
            AddHandler Me.gridView1.MasterRowGetRelationName, New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(AddressOf Me.OnMasterRowGetRelationName)
            AddHandler Me.gridView1.MasterRowGetRelationCount, New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(AddressOf Me.OnMasterRowGetRelationCount)
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1025, 614)
            Me.Controls.Add(Me.gridControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "A master-detail grid with Entity Framework objects (many-to-many)"
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace
