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
using WarehouseLibrary.My_Exceptions;

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

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Save data before exit?", "Exit", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    warehouse.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer(warehouse, customerBindingSource);
            newCustomer.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (warehouse.Customers.Count == 0)
                {
                    throw new CustomerException("Nothing to delete");
                }
                var toDel = (Customer)customerBindingSource.Current;
                if (toDel != null)
                {
                    var res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete", MessageBoxButtons.YesNo);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            warehouse.Customers.Remove(toDel);
                            customerBindingSource.ResetBindings(false);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
            catch (CustomerException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void newSupplyButton_Click(object sender, EventArgs e)
        {
            NewSupply newSupply = new NewSupply(warehouse, productBindingSource);
            newSupply.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPassword newPassword = new NewPassword(warehouse);
            newPassword.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse.Save();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Order)orderBindingSource.Current == null)
                {
                    throw new OrderException("No orders");
                }
                warehouse.СonfirmationOfOrder((Order)orderBindingSource.Current);
                orderBindingSource.ResetBindings(false);
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Order)orderBindingSource.Current == null)
                {
                    throw new OrderException("No orders");
                }
                Details details = new Details(warehouse, (Order)orderBindingSource.Current);
                details.ShowDialog();
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void buttonSalesInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                if (warehouse.SalesInvoices.Count == 0) 
                {
                    throw new InvoiceException("No sales invoices");
                }
                SalesInvoices salesesInvoice = new SalesInvoices(warehouse);
                salesesInvoice.ShowDialog();
            }
            catch(InvoiceException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void purchaseInvoicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (warehouse.PurchaseInvoices.Count == 0)
                {
                    throw new InvoiceException("No purchase invoices");
                }
                PurchaseInvoices purchaseInvoice = new PurchaseInvoices(warehouse);
                purchaseInvoice.ShowDialog();
            }
            catch (InvoiceException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(warehouse, productBindingSource);
            inventory.ShowDialog();
        }
    }
}
