Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraGrid.Views.Grid


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			myGridControl1.DataSource = Nothing
			myGridControl1.DataSource = GetData()
			myGridView1.PopulateColumns()

		End Sub

		Private Function GetData() As BindingList(Of Custom)
			Dim list As BindingList(Of Custom) = New BindingList(Of Custom)()
			For i As Integer = 0 To 9
				list.Add(New Custom() With {
					.ID = i,
					.Name = "Name" & i
				})
			Next i
			Return list
		End Function

		Private Sub myGridView1_CustomDrawGridLine(ByVal sender As Object, ByVal e As CustomDrawLineEventArgs) Handles myGridView1.CustomDrawGridLine
			If e.CellInfo IsNot Nothing Then
				If e.CellInfo.RowHandle Mod 2 = 0 Then
					e.Appearance.BackColor = Color.BlueViolet
				Else
					e.Appearance.BackColor = Color.DarkOrange
				End If
			Else
				Dim brush As New HatchBrush(HatchStyle.Trellis, Color.Green, Color.Yellow)
				e.Graphics.FillRectangle(brush, e.Bounds)
				e.Handled = True
			End If
		End Sub
	End Class

	Public Class Custom
		Public Property ID() As Integer
		Public Property Name() As String
	End Class
End Namespace
