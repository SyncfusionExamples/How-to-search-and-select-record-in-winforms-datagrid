Imports Microsoft.VisualBasic
Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.DataGrid.Styles
Imports System.Windows.Forms
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid

Namespace GettingStarted
	Partial Public Class Form1
		Inherits Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			Dim data = New OrderInfoCollection()
			sfDataGrid.DataSource = data.OrdersListDetails
		End Sub

		#End Region 

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
			Me.sfDataGrid.SearchController.Search(Me.textBox1.Text)
		End Sub

		Private Sub nextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.sfDataGrid.SearchController.FindNext(Me.textBox1.Text)
			SetSelectedItem()
		End Sub

		Private Sub previousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.sfDataGrid.SearchController.FindPrevious(Me.textBox1.Text)
			SetSelectedItem()
		End Sub

		Private Sub SetSelectedItem()
			Dim rowIndex = Me.sfDataGrid.SearchController.CurrentRowColumnIndex.RowIndex
			Dim recordIndex = Me.sfDataGrid.TableControl.ResolveToRecordIndex(rowIndex)
			Me.sfDataGrid.SelectedIndex = recordIndex
		End Sub
	End Class
End Namespace
