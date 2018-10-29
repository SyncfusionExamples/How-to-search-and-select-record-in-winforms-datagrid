using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;

namespace GettingStarted
{   
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;
        }

        #endregion 

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
    }
}
