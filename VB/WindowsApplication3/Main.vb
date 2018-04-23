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
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)

		End Sub

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
End Namespace
