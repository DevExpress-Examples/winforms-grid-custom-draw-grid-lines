Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing

Namespace DXSample
	Public Class CustomDrawLineEventArgs
'INSTANT VB NOTE: The variable cache was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private cache_Renamed As GraphicsCache
'INSTANT VB NOTE: The variable handled was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private handled_Renamed As Boolean
'INSTANT VB NOTE: The variable bounds was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private bounds_Renamed As Rectangle
'INSTANT VB NOTE: The variable cellInfo was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private cellInfo_Renamed As GridCellInfo
'INSTANT VB NOTE: The variable appearance was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private appearance_Renamed As AppearanceObject

		Public Sub New(ByVal cache As GraphicsCache, ByVal appearance As AppearanceObject, ByVal bounds As Rectangle, ByVal cellInfo As GridCellInfo)
			Me.cache_Renamed = cache
			Me.bounds_Renamed = bounds
			Me.cellInfo_Renamed = cellInfo
			Me.appearance_Renamed = appearance
		End Sub

		Public ReadOnly Property Cache() As GraphicsCache
			Get
				Return cache_Renamed
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