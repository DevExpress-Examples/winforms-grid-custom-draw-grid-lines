Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports DevExpress.Utils

Namespace DXSample

    Public Class CustomDrawLineEventArgs

        Private graphicsField As Graphics

        Private handledField As Boolean

        Private boundsField As Rectangle

        Private cellInfoField As GridCellInfo

        Private appearanceField As AppearanceObject

        Public Sub New(ByVal graphics As Graphics, ByVal appearance As AppearanceObject, ByVal bounds As Rectangle, ByVal cellInfo As GridCellInfo)
            graphicsField = graphics
            boundsField = bounds
            cellInfoField = cellInfo
            appearanceField = appearance
        End Sub

        Public ReadOnly Property Graphics As Graphics
            Get
                Return graphicsField
            End Get
        End Property

        Public ReadOnly Property Appearance As AppearanceObject
            Get
                Return appearanceField
            End Get
        End Property

        Public Property Handled As Boolean
            Get
                Return handledField
            End Get

            Set(ByVal value As Boolean)
                handledField = value
            End Set
        End Property

        Public ReadOnly Property Bounds As Rectangle
            Get
                Return boundsField
            End Get
        End Property

        Public ReadOnly Property CellInfo As GridCellInfo
            Get
                Return cellInfoField
            End Get
        End Property
    End Class

    Public Delegate Sub CustomDrawLineEventHandler(ByVal sender As Object, ByVal e As CustomDrawLineEventArgs)
End Namespace
