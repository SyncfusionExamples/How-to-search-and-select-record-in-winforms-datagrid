# How to search and select record in WinForms DataGrid (SfDataGrid)

## Search and select record

You can search and select a record in SfDataGrid based on the searched text by using the TextChanged event of TextBox.

## C#

```C#
private void textBox1_TextChanged(object sender, System.EventArgs e)
{
    this.sfDataGrid.SearchController.Search(this.textBox1.Text);
}
 
private void nextButton_Click(object sender, System.EventArgs e)
{
    this.sfDataGrid.SearchController.FindNext(this.textBox1.Text);
    SetSelectedItem();
}
 
private void previousButton_Click(object sender, System.EventArgs e)
{
    this.sfDataGrid.SearchController.FindPrevious(this.textBox1.Text);
    SetSelectedItem();
}
 
private void SetSelectedItem()
{
    var rowIndex = this.sfDataGrid.SearchController.CurrentRowColumnIndex.RowIndex;
    var recordIndex = this.sfDataGrid.TableControl.ResolveToRecordIndex(rowIndex);
    this.sfDataGrid.SelectedIndex = recordIndex;
}
```

## VB

```VB
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
```
 