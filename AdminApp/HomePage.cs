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
    public partial class HomePage : Form
    {
        Warehouse warehouse;
        public HomePage(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            productBindingSource.DataSource = warehouse.Products;
            orderBindingSource.DataSource = warehouse.Orders;
            customerBindingSource.DataSource = warehouse.Customers;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer(warehouse, customerBindingSource);
            newCustomer.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var toDel = (Customer)customerBindingSource.Current;
            if (toDel != null)
            {
                MessageBox.Show($"Delete {toDel.Login}?");
                warehouse.Customers.Remove(toDel);
                customerBindingSource.ResetBindings(false);
            }
        }

        private void newSupplyButton_Click(object sender, EventArgs e)
        {
            NewSupply newSupply = new NewSupply(warehouse, productBindingSource);
            newSupply.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPassword newPassword = new NewPassword();
            newPassword.Show();
        }

        private void purchasesInvoicesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
