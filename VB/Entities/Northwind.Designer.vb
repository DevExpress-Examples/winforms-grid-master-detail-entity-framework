﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4952
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute()>
<Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("NorthwindModel", "FK_Order_Details_Orders", "Order", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(DXSample.Order), "Order_Detail", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(DXSample.Order_Detail))>
<Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("NorthwindModel", "FK_Order_Details_Products", "Product", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(DXSample.Product), "Order_Detail", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(DXSample.Order_Detail))>

' Original file name:
' Generation date: 12/16/2010 11:24:43 AM
Namespace DXSample

	''' <summary>
	''' There are no comments for NorthwindEntities in the schema.
	''' </summary>
	Partial Public Class NorthwindEntities
		Inherits System.Data.Objects.ObjectContext
		''' <summary>
		''' Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
		''' </summary>
		Public Sub New()
			MyBase.New("name=NorthwindEntities", "NorthwindEntities")
			Me.OnContextCreated()
		End Sub
		''' <summary>
		''' Initialize a new NorthwindEntities object.
		''' </summary>
		Public Sub New(ByVal connectionString As String)
			MyBase.New(connectionString, "NorthwindEntities")
			Me.OnContextCreated()
		End Sub
		''' <summary>
		''' Initialize a new NorthwindEntities object.
		''' </summary>
		Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
			MyBase.New(connection, "NorthwindEntities")
			Me.OnContextCreated()
		End Sub
		Partial Private Sub OnContextCreated()
		End Sub
		''' <summary>
		''' There are no comments for Products in the schema.
		''' </summary>
		Public ReadOnly Property Products() As Global.System.Data.Objects.ObjectQuery(Of Product)
			Get
				If (Me._Products Is Nothing) Then
					Me._Products = MyBase.CreateQuery(Of Product)("[Products]")
				End If
				Return Me._Products
			End Get
		End Property
		Private _Products As Global.System.Data.Objects.ObjectQuery(Of Product)
		''' <summary>
		''' There are no comments for Orders in the schema.
		''' </summary>
		Public ReadOnly Property Orders() As Global.System.Data.Objects.ObjectQuery(Of Order)
			Get
				If (Me._Orders Is Nothing) Then
					Me._Orders = MyBase.CreateQuery(Of Order)("[Orders]")
				End If
				Return Me._Orders
			End Get
		End Property
		Private _Orders As Global.System.Data.Objects.ObjectQuery(Of Order)
		''' <summary>
		''' There are no comments for Order_Details in the schema.
		''' </summary>
		Public ReadOnly Property Order_Details() As Global.System.Data.Objects.ObjectQuery(Of Order_Detail)
			Get
				If (Me._Order_Details Is Nothing) Then
					Me._Order_Details = MyBase.CreateQuery(Of Order_Detail)("[Order_Details]")
				End If
				Return Me._Order_Details
			End Get
		End Property
		Private _Order_Details As Global.System.Data.Objects.ObjectQuery(Of Order_Detail)
		''' <summary>
		''' There are no comments for Products in the schema.
		''' </summary>
		Public Sub AddToProducts(ByVal product As Product)
			MyBase.AddObject("Products", product)
		End Sub
		''' <summary>
		''' There are no comments for Orders in the schema.
		''' </summary>
		Public Sub AddToOrders(ByVal order As Order)
			MyBase.AddObject("Orders", order)
		End Sub
		''' <summary>
		''' There are no comments for Order_Details in the schema.
		''' </summary>
		Public Sub AddToOrder_Details(ByVal order_Detail As Order_Detail)
			MyBase.AddObject("Order_Details", order_Detail)
		End Sub
	End Class
	''' <summary>
	''' There are no comments for NorthwindModel.Product in the schema.
	''' </summary>
	''' <KeyProperties>
	''' ProductID
	''' </KeyProperties>
	<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Product"), Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), Global.System.Serializable()> _
	Partial Public Class Product
		Inherits System.Data.Objects.DataClasses.EntityObject
		''' <summary>
		''' Create a new Product object.
		''' </summary>
		''' <param name="productID">Initial value of ProductID.</param>
		''' <param name="productName">Initial value of ProductName.</param>
		''' <param name="discontinued">Initial value of Discontinued.</param>
		Public Shared Function CreateProduct(ByVal productID As Integer, ByVal productName As String, ByVal discontinued As Boolean) As Product
			Dim product As New Product()
			product.ProductID = productID
			product.ProductName = productName
			product.Discontinued = discontinued
			Return product
		End Function
		''' <summary>
		''' There are no comments for Property ProductID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ProductID() As Integer
			Get
				Return Me._ProductID
			End Get
			Set(ByVal value As Integer)
				Me.OnProductIDChanging(value)
				Me.ReportPropertyChanging("ProductID")
				Me._ProductID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("ProductID")
				Me.OnProductIDChanged()
			End Set
		End Property
		Private _ProductID As Integer
		Partial Private Sub OnProductIDChanging(ByVal value As Integer)
		End Sub
		Partial Private Sub OnProductIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ProductName in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ProductName() As String
			Get
				Return Me._ProductName
			End Get
			Set(ByVal value As String)
				Me.OnProductNameChanging(value)
				Me.ReportPropertyChanging("ProductName")
				Me._ProductName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, False)
				Me.ReportPropertyChanged("ProductName")
				Me.OnProductNameChanged()
			End Set
		End Property
		Private _ProductName As String
		Partial Private Sub OnProductNameChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnProductNameChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property SupplierID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property SupplierID() As Integer?
			Get
				Return Me._SupplierID
			End Get
			Set(ByVal value? As Integer)
				Me.OnSupplierIDChanging(value)
				Me.ReportPropertyChanging("SupplierID")
				Me._SupplierID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("SupplierID")
				Me.OnSupplierIDChanged()
			End Set
		End Property
		Private _SupplierID? As Integer
		Partial Private Sub OnSupplierIDChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnSupplierIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property CategoryID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property CategoryID() As Integer?
			Get
				Return Me._CategoryID
			End Get
			Set(ByVal value? As Integer)
				Me.OnCategoryIDChanging(value)
				Me.ReportPropertyChanging("CategoryID")
				Me._CategoryID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("CategoryID")
				Me.OnCategoryIDChanged()
			End Set
		End Property
		Private _CategoryID? As Integer
		Partial Private Sub OnCategoryIDChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnCategoryIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property QuantityPerUnit in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property QuantityPerUnit() As String
			Get
				Return Me._QuantityPerUnit
			End Get
			Set(ByVal value As String)
				Me.OnQuantityPerUnitChanging(value)
				Me.ReportPropertyChanging("QuantityPerUnit")
				Me._QuantityPerUnit = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("QuantityPerUnit")
				Me.OnQuantityPerUnitChanged()
			End Set
		End Property
		Private _QuantityPerUnit As String
		Partial Private Sub OnQuantityPerUnitChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnQuantityPerUnitChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property UnitPrice in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property UnitPrice() As Decimal?
			Get
				Return Me._UnitPrice
			End Get
			Set(ByVal value? As Decimal)
				Me.OnUnitPriceChanging(value)
				Me.ReportPropertyChanging("UnitPrice")
				Me._UnitPrice = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("UnitPrice")
				Me.OnUnitPriceChanged()
			End Set
		End Property
		Private _UnitPrice? As Decimal
		Partial Private Sub OnUnitPriceChanging(ByVal value? As Decimal)
		End Sub
		Partial Private Sub OnUnitPriceChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property UnitsInStock in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property UnitsInStock() As Short?
			Get
				Return Me._UnitsInStock
			End Get
			Set(ByVal value? As Short)
				Me.OnUnitsInStockChanging(value)
				Me.ReportPropertyChanging("UnitsInStock")
				Me._UnitsInStock = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("UnitsInStock")
				Me.OnUnitsInStockChanged()
			End Set
		End Property
		Private _UnitsInStock? As Short
		Partial Private Sub OnUnitsInStockChanging(ByVal value? As Short)
		End Sub
		Partial Private Sub OnUnitsInStockChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property UnitsOnOrder in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property UnitsOnOrder() As Short?
			Get
				Return Me._UnitsOnOrder
			End Get
			Set(ByVal value? As Short)
				Me.OnUnitsOnOrderChanging(value)
				Me.ReportPropertyChanging("UnitsOnOrder")
				Me._UnitsOnOrder = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("UnitsOnOrder")
				Me.OnUnitsOnOrderChanged()
			End Set
		End Property
		Private _UnitsOnOrder? As Short
		Partial Private Sub OnUnitsOnOrderChanging(ByVal value? As Short)
		End Sub
		Partial Private Sub OnUnitsOnOrderChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ReorderLevel in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ReorderLevel() As Short?
			Get
				Return Me._ReorderLevel
			End Get
			Set(ByVal value? As Short)
				Me.OnReorderLevelChanging(value)
				Me.ReportPropertyChanging("ReorderLevel")
				Me._ReorderLevel = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("ReorderLevel")
				Me.OnReorderLevelChanged()
			End Set
		End Property
		Private _ReorderLevel? As Short
		Partial Private Sub OnReorderLevelChanging(ByVal value? As Short)
		End Sub
		Partial Private Sub OnReorderLevelChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Discontinued in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Discontinued() As Boolean
			Get
				Return Me._Discontinued
			End Get
			Set(ByVal value As Boolean)
				Me.OnDiscontinuedChanging(value)
				Me.ReportPropertyChanging("Discontinued")
				Me._Discontinued = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("Discontinued")
				Me.OnDiscontinuedChanged()
			End Set
		End Property
		Private _Discontinued As Boolean
		Partial Private Sub OnDiscontinuedChanging(ByVal value As Boolean)
		End Sub
		Partial Private Sub OnDiscontinuedChanged()
		End Sub
		''' <summary>
		''' There are no comments for Order_Details in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Order_Details_Products", "Order_Detail"), Global.System.Xml.Serialization.XmlIgnoreAttribute(), Global.System.Xml.Serialization.SoapIgnoreAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Order_Details() As Global.System.Data.Objects.DataClasses.EntityCollection(Of Order_Detail)
			Get
				Return (CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships)).RelationshipManager.GetRelatedCollection(Of Order_Detail)("NorthwindModel.FK_Order_Details_Products", "Order_Detail")
			End Get
			Set(ByVal value As System.Data.Objects.DataClasses.EntityCollection(Of Order_Detail))
				If (value IsNot Nothing) Then
					CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Order_Detail)("NorthwindModel.FK_Order_Details_Products", "Order_Detail", value)
				End If
			End Set
		End Property
	End Class
	''' <summary>
	''' There are no comments for NorthwindModel.Order in the schema.
	''' </summary>
	''' <KeyProperties>
	''' OrderID
	''' </KeyProperties>
	<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Order"), Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), Global.System.Serializable()> _
	Partial Public Class Order
		Inherits System.Data.Objects.DataClasses.EntityObject
		''' <summary>
		''' Create a new Order object.
		''' </summary>
		''' <param name="orderID">Initial value of OrderID.</param>
		Public Shared Function CreateOrder(ByVal orderID As Integer) As Order
			Dim order As New Order()
			order.OrderID = orderID
			Return order
		End Function
		''' <summary>
		''' There are no comments for Property OrderID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				Me.OnOrderIDChanging(value)
				Me.ReportPropertyChanging("OrderID")
				Me._OrderID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("OrderID")
				Me.OnOrderIDChanged()
			End Set
		End Property
		Private _OrderID As Integer
		Partial Private Sub OnOrderIDChanging(ByVal value As Integer)
		End Sub
		Partial Private Sub OnOrderIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property CustomerID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property CustomerID() As String
			Get
				Return Me._CustomerID
			End Get
			Set(ByVal value As String)
				Me.OnCustomerIDChanging(value)
				Me.ReportPropertyChanging("CustomerID")
				Me._CustomerID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged()
			End Set
		End Property
		Private _CustomerID As String
		Partial Private Sub OnCustomerIDChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnCustomerIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property EmployeeID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property EmployeeID() As Integer?
			Get
				Return Me._EmployeeID
			End Get
			Set(ByVal value? As Integer)
				Me.OnEmployeeIDChanging(value)
				Me.ReportPropertyChanging("EmployeeID")
				Me._EmployeeID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("EmployeeID")
				Me.OnEmployeeIDChanged()
			End Set
		End Property
		Private _EmployeeID? As Integer
		Partial Private Sub OnEmployeeIDChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnEmployeeIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property OrderDate in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property OrderDate() As Global.System.DateTime?
			Get
				Return Me._OrderDate
			End Get
			Set(ByVal value? As System.DateTime)
				Me.OnOrderDateChanging(value)
				Me.ReportPropertyChanging("OrderDate")
				Me._OrderDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("OrderDate")
				Me.OnOrderDateChanged()
			End Set
		End Property
		Private _OrderDate? As Global.System.DateTime
		Partial Private Sub OnOrderDateChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnOrderDateChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property RequiredDate in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property RequiredDate() As Global.System.DateTime?
			Get
				Return Me._RequiredDate
			End Get
			Set(ByVal value? As System.DateTime)
				Me.OnRequiredDateChanging(value)
				Me.ReportPropertyChanging("RequiredDate")
				Me._RequiredDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("RequiredDate")
				Me.OnRequiredDateChanged()
			End Set
		End Property
		Private _RequiredDate? As Global.System.DateTime
		Partial Private Sub OnRequiredDateChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnRequiredDateChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShippedDate in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShippedDate() As Global.System.DateTime?
			Get
				Return Me._ShippedDate
			End Get
			Set(ByVal value? As System.DateTime)
				Me.OnShippedDateChanging(value)
				Me.ReportPropertyChanging("ShippedDate")
				Me._ShippedDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("ShippedDate")
				Me.OnShippedDateChanged()
			End Set
		End Property
		Private _ShippedDate? As Global.System.DateTime
		Partial Private Sub OnShippedDateChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnShippedDateChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipVia in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipVia() As Integer?
			Get
				Return Me._ShipVia
			End Get
			Set(ByVal value? As Integer)
				Me.OnShipViaChanging(value)
				Me.ReportPropertyChanging("ShipVia")
				Me._ShipVia = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("ShipVia")
				Me.OnShipViaChanged()
			End Set
		End Property
		Private _ShipVia? As Integer
		Partial Private Sub OnShipViaChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnShipViaChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Freight in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Freight() As Decimal?
			Get
				Return Me._Freight
			End Get
			Set(ByVal value? As Decimal)
				Me.OnFreightChanging(value)
				Me.ReportPropertyChanging("Freight")
				Me._Freight = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("Freight")
				Me.OnFreightChanged()
			End Set
		End Property
		Private _Freight? As Decimal
		Partial Private Sub OnFreightChanging(ByVal value? As Decimal)
		End Sub
		Partial Private Sub OnFreightChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipName in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipName() As String
			Get
				Return Me._ShipName
			End Get
			Set(ByVal value As String)
				Me.OnShipNameChanging(value)
				Me.ReportPropertyChanging("ShipName")
				Me._ShipName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("ShipName")
				Me.OnShipNameChanged()
			End Set
		End Property
		Private _ShipName As String
		Partial Private Sub OnShipNameChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnShipNameChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipAddress in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipAddress() As String
			Get
				Return Me._ShipAddress
			End Get
			Set(ByVal value As String)
				Me.OnShipAddressChanging(value)
				Me.ReportPropertyChanging("ShipAddress")
				Me._ShipAddress = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("ShipAddress")
				Me.OnShipAddressChanged()
			End Set
		End Property
		Private _ShipAddress As String
		Partial Private Sub OnShipAddressChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnShipAddressChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipCity in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipCity() As String
			Get
				Return Me._ShipCity
			End Get
			Set(ByVal value As String)
				Me.OnShipCityChanging(value)
				Me.ReportPropertyChanging("ShipCity")
				Me._ShipCity = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("ShipCity")
				Me.OnShipCityChanged()
			End Set
		End Property
		Private _ShipCity As String
		Partial Private Sub OnShipCityChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnShipCityChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipRegion in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipRegion() As String
			Get
				Return Me._ShipRegion
			End Get
			Set(ByVal value As String)
				Me.OnShipRegionChanging(value)
				Me.ReportPropertyChanging("ShipRegion")
				Me._ShipRegion = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("ShipRegion")
				Me.OnShipRegionChanged()
			End Set
		End Property
		Private _ShipRegion As String
		Partial Private Sub OnShipRegionChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnShipRegionChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipPostalCode in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipPostalCode() As String
			Get
				Return Me._ShipPostalCode
			End Get
			Set(ByVal value As String)
				Me.OnShipPostalCodeChanging(value)
				Me.ReportPropertyChanging("ShipPostalCode")
				Me._ShipPostalCode = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("ShipPostalCode")
				Me.OnShipPostalCodeChanged()
			End Set
		End Property
		Private _ShipPostalCode As String
		Partial Private Sub OnShipPostalCodeChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnShipPostalCodeChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ShipCountry in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ShipCountry() As String
			Get
				Return Me._ShipCountry
			End Get
			Set(ByVal value As String)
				Me.OnShipCountryChanging(value)
				Me.ReportPropertyChanging("ShipCountry")
				Me._ShipCountry = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
				Me.ReportPropertyChanged("ShipCountry")
				Me.OnShipCountryChanged()
			End Set
		End Property
		Private _ShipCountry As String
		Partial Private Sub OnShipCountryChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnShipCountryChanged()
		End Sub
		''' <summary>
		''' There are no comments for Order_Details in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Order_Details_Orders", "Order_Detail"), Global.System.Xml.Serialization.XmlIgnoreAttribute(), Global.System.Xml.Serialization.SoapIgnoreAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Order_Details() As Global.System.Data.Objects.DataClasses.EntityCollection(Of Order_Detail)
			Get
				Return (CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships)).RelationshipManager.GetRelatedCollection(Of Order_Detail)("NorthwindModel.FK_Order_Details_Orders", "Order_Detail")
			End Get
			Set(ByVal value As System.Data.Objects.DataClasses.EntityCollection(Of Order_Detail))
				If (value IsNot Nothing) Then
					CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Order_Detail)("NorthwindModel.FK_Order_Details_Orders", "Order_Detail", value)
				End If
			End Set
		End Property
	End Class
	''' <summary>
	''' There are no comments for NorthwindModel.Order_Detail in the schema.
	''' </summary>
	''' <KeyProperties>
	''' OrderID
	''' ProductID
	''' </KeyProperties>
	<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Order_Detail"), Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), Global.System.Serializable()> _
	Partial Public Class Order_Detail
		Inherits System.Data.Objects.DataClasses.EntityObject
		''' <summary>
		''' Create a new Order_Detail object.
		''' </summary>
		''' <param name="orderID">Initial value of OrderID.</param>
		''' <param name="productID">Initial value of ProductID.</param>
		''' <param name="unitPrice">Initial value of UnitPrice.</param>
		''' <param name="quantity">Initial value of Quantity.</param>
		''' <param name="discount">Initial value of Discount.</param>
		Public Shared Function CreateOrder_Detail(ByVal orderID As Integer, ByVal productID As Integer, ByVal unitPrice As Decimal, ByVal quantity As Short, ByVal discount As Single) As Order_Detail
			Dim order_Detail As New Order_Detail()
			order_Detail.OrderID = orderID
			order_Detail.ProductID = productID
			order_Detail.UnitPrice = unitPrice
			order_Detail.Quantity = quantity
			order_Detail.Discount = discount
			Return order_Detail
		End Function
		''' <summary>
		''' There are no comments for Property OrderID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				Me.OnOrderIDChanging(value)
				Me.ReportPropertyChanging("OrderID")
				Me._OrderID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("OrderID")
				Me.OnOrderIDChanged()
			End Set
		End Property
		Private _OrderID As Integer
		Partial Private Sub OnOrderIDChanging(ByVal value As Integer)
		End Sub
		Partial Private Sub OnOrderIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ProductID in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ProductID() As Integer
			Get
				Return Me._ProductID
			End Get
			Set(ByVal value As Integer)
				Me.OnProductIDChanging(value)
				Me.ReportPropertyChanging("ProductID")
				Me._ProductID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("ProductID")
				Me.OnProductIDChanged()
			End Set
		End Property
		Private _ProductID As Integer
		Partial Private Sub OnProductIDChanging(ByVal value As Integer)
		End Sub
		Partial Private Sub OnProductIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property UnitPrice in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property UnitPrice() As Decimal
			Get
				Return Me._UnitPrice
			End Get
			Set(ByVal value As Decimal)
				Me.OnUnitPriceChanging(value)
				Me.ReportPropertyChanging("UnitPrice")
				Me._UnitPrice = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("UnitPrice")
				Me.OnUnitPriceChanged()
			End Set
		End Property
		Private _UnitPrice As Decimal
		Partial Private Sub OnUnitPriceChanging(ByVal value As Decimal)
		End Sub
		Partial Private Sub OnUnitPriceChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Quantity in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Quantity() As Short
			Get
				Return Me._Quantity
			End Get
			Set(ByVal value As Short)
				Me.OnQuantityChanging(value)
				Me.ReportPropertyChanging("Quantity")
				Me._Quantity = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("Quantity")
				Me.OnQuantityChanged()
			End Set
		End Property
		Private _Quantity As Short
		Partial Private Sub OnQuantityChanging(ByVal value As Short)
		End Sub
		Partial Private Sub OnQuantityChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Discount in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Discount() As Single
			Get
				Return Me._Discount
			End Get
			Set(ByVal value As Single)
				Me.OnDiscountChanging(value)
				Me.ReportPropertyChanging("Discount")
				Me._Discount = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
				Me.ReportPropertyChanged("Discount")
				Me.OnDiscountChanged()
			End Set
		End Property
		Private _Discount As Single
		Partial Private Sub OnDiscountChanging(ByVal value As Single)
		End Sub
		Partial Private Sub OnDiscountChanged()
		End Sub
		''' <summary>
		''' There are no comments for Order in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Order_Details_Orders", "Order"), Global.System.Xml.Serialization.XmlIgnoreAttribute(), Global.System.Xml.Serialization.SoapIgnoreAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Order() As Order
			Get
				Return (CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships)).RelationshipManager.GetRelatedReference(Of Order)("NorthwindModel.FK_Order_Details_Orders", "Order").Value
			End Get
			Set(ByVal value As Order)
				CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Order)("NorthwindModel.FK_Order_Details_Orders", "Order").Value = value
			End Set
		End Property
		''' <summary>
		''' There are no comments for Order in the schema.
		''' </summary>
		<Global.System.ComponentModel.BrowsableAttribute(False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property OrderReference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Order)
			Get
				Return (CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships)).RelationshipManager.GetRelatedReference(Of Order)("NorthwindModel.FK_Order_Details_Orders", "Order")
			End Get
			Set(ByVal value As System.Data.Objects.DataClasses.EntityReference(Of Order))
				If (value IsNot Nothing) Then
					CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Order)("NorthwindModel.FK_Order_Details_Orders", "Order", value)
				End If
			End Set
		End Property
		''' <summary>
		''' There are no comments for Product in the schema.
		''' </summary>
		<Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Order_Details_Products", "Product"), Global.System.Xml.Serialization.XmlIgnoreAttribute(), Global.System.Xml.Serialization.SoapIgnoreAttribute(), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Product() As Product
			Get
				Return (CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships)).RelationshipManager.GetRelatedReference(Of Product)("NorthwindModel.FK_Order_Details_Products", "Product").Value
			End Get
			Set(ByVal value As Product)
				CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Product)("NorthwindModel.FK_Order_Details_Products", "Product").Value = value
			End Set
		End Property
		''' <summary>
		''' There are no comments for Product in the schema.
		''' </summary>
		<Global.System.ComponentModel.BrowsableAttribute(False), Global.System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ProductReference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Product)
			Get
				Return (CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships)).RelationshipManager.GetRelatedReference(Of Product)("NorthwindModel.FK_Order_Details_Products", "Product")
			End Get
			Set(ByVal value As System.Data.Objects.DataClasses.EntityReference(Of Product))
				If (value IsNot Nothing) Then
					CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Product)("NorthwindModel.FK_Order_Details_Products", "Product", value)
				End If
			End Set
		End Property
	End Class
End Namespace
