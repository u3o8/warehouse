using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseLibrary.Models;

namespace AdminApp
{
    // Форма для инвентаризации.
    //
    public partial class Inventory : Form
    {
        Warehouse warehouse;
        BindingSource productGridHome;
        public Inventory(Warehouse warehouse, BindingSource productGridHome)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            productBindingSource.DataSource = warehouse.Products;
            this.productGridHome = productGridHome;
        }

        // Действие при нажатии на продукт в нашей сетке productGrid. 
        private void productGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            amountNumericUpDown.Value = (decimal)((Product)productBindingSource.Current).Amount;
        }

        // Действие при нажатии на кнопку okButton.
        private void okButton_Click(object sender, EventArgs e)
        {
            ((Product)productBindingSource.Current).Amount = (double)amountNumericUpDown.Value;
            productBindingSource.ResetBindings(false);
            productGridHome.ResetBindings(false);
        }

        // Действие при нажатии на кнопку confirmButton.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
