Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports System.Drawing
Imports DevExpress.Utils

Namespace DXSample
	Public Class CustomDrawLineEventArgs
		Private graphics_Renamed As Graphics
		Private handled_Renamed As Boolean
		Private bounds_Renamed As Rectangle
		Private cellInfo_Renamed As GridCellInfo
		Private appearance_Renamed As AppearanceObject

		Public Sub New(ByVal graphics As Graphics, ByVal appearance As AppearanceObject, ByVal bounds As Rectangle, ByVal cellInfo As GridCellInfo)
			Me.graphics_Renamed = graphics
			Me.bounds_Renamed = bounds
			Me.cellInfo_Renamed = cellInfo
			Me.appearance_Renamed = appearance
		End Sub

		Public ReadOnly Property Graphics() As Graphics
			Get
				Return graphics_Renamed
			End Get
		End Property

		Public ReadOnly Property Appearance() As AppearanceObject
			Get
				Return appearance_Renamed
			End Get
		End Property

		Public Property Handled() As Boolean
			Get
				Return handled_Renamed
			End Get
			Set(ByVal value As Boolean)
				handled_Renamed = value
			End Set
		End Property

		Public ReadOnly Property Bounds() As Rectangle
			Get
				Return bounds_Renamed
			End Get
		End Property

		Public ReadOnly Property CellInfo() As GridCellInfo
			Get
				Return cellInfo_Renamed
			End Get
		End Property
	End Class

	Public Delegate Sub CustomDrawLineEventHandler(ByVal sender As Object, ByVal e As CustomDrawLineEventArgs)
End Namespace