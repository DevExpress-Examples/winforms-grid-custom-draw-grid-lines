Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports System.Drawing.Drawing2D

Namespace DXSample

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            customersTableAdapter.Fill(nwindDataSet.Customers)
        End Sub

        Private Sub myGridView1_CustomDrawGridLine(ByVal sender As Object, ByVal e As CustomDrawLineEventArgs)
            If e.CellInfo IsNot Nothing Then
                e.Appearance.BackColor = If(e.CellInfo.RowHandle Mod 2 = 0, Color.BlueViolet, Color.DarkOrange)
            Else
                Dim brush As HatchBrush = New HatchBrush(HatchStyle.Trellis, Color.Green, Color.Yellow)
                e.Graphics.FillRectangle(brush, e.Bounds)
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
