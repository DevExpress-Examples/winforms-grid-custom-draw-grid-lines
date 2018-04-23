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
	Public Class MyGridPainter
		Inherits GridPainter
		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
		End Sub
		Protected Overrides Sub DrawLine(ByVal e As ViewDrawArgs, ByVal indent As IndentInfo)
			If (Not IsAllowDrawIndent(indent)) Then
				Return
			End If
			Dim args As New CustomDrawLineEventArgs(e.Graphics, indent.Appearance, indent.Bounds, TryCast(indent.IndentOwner, GridCellInfo))
			View.RaiseCustomDrawGridLine(args)
			If args.Handled Then
				Return
			End If
			MyBase.DrawLine(e, indent)
		End Sub

		Public Shadows ReadOnly Property View() As MyGridView
			Get
				Return TryCast(MyBase.View, MyGridView)
			End Get
		End Property
	End Class
End Namespace

