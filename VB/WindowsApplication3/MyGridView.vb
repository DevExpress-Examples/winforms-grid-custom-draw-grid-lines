Namespace DXSample

    Public Class MyGridView
        Inherits DevExpress.XtraGrid.Views.Grid.GridView

        Public Event CustomDrawGridLine As CustomDrawLineEventHandler

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
            MyBase.New(grid)
        ' put your initialization code here
        End Sub

        Protected Overrides ReadOnly Property ViewName As String
            Get
                Return "MyGridView"
            End Get
        End Property

        Friend Sub RaiseCustomDrawGridLine(ByVal e As CustomDrawLineEventArgs)
            RaiseEvent CustomDrawGridLine(Me, e)
        End Sub
    End Class
End Namespace
