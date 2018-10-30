Imports Microsoft.VisualBasic
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports System.Windows.Forms

Namespace GettingStarted
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.sfDataGrid = New Syncfusion.WinForms.DataGrid.SfDataGrid()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			CType(Me.sfDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' sfDataGrid
			' 
			Me.sfDataGrid.AccessibleName = "Table"
			Me.sfDataGrid.AllowDraggingColumns = True
			Me.sfDataGrid.AllowFiltering = True
			Me.sfDataGrid.AllowResizingColumns = True
			Me.sfDataGrid.AllowResizingHiddenColumns = True
			Me.sfDataGrid.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
			Me.sfDataGrid.BackColor = System.Drawing.SystemColors.Window
			Me.sfDataGrid.Location = New System.Drawing.Point(10, 5)
			Me.sfDataGrid.Name = "sfDataGrid"
			Me.sfDataGrid.ShowGroupDropArea = False
			Me.sfDataGrid.Size = New System.Drawing.Size(782, 580)
			Me.sfDataGrid.TabIndex = 1
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(25, 32)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(165, 20)
			Me.textBox1.TabIndex = 2
'			Me.textBox1.TextChanged += New System.EventHandler(Me.textBox1_TextChanged)
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(115, 65)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 3
			Me.button1.Text = "Next"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.nextButton_Click)
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(25, 65)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 4
			Me.button2.Text = "Previous"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.previousButton_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Location = New System.Drawing.Point(798, 5)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(196, 100)
			Me.groupBox1.TabIndex = 5
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Search Here"
			' 
			' Form1
			' 
			Me.BackColor = System.Drawing.SystemColors.Window
			Me.ClientSize = New System.Drawing.Size(1006, 593)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.sfDataGrid)
			Me.Margin = New System.Windows.Forms.Padding(5)
			Me.MinimumSize = New System.Drawing.Size(500, 400)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Getting Started"
			CType(Me.sfDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		#Region "API Definition"

		Private sfDataGrid As SfDataGrid

		#End Region
		Private WithEvents textBox1 As TextBox
		Private WithEvents button1 As Button
		Private WithEvents button2 As Button
		Private groupBox1 As GroupBox
	End Class
End Namespace

