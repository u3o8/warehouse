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
    // Форма главной страницы.
    //
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

        // Действия до закрытия формы.
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

        // Действия после закрытия формы.
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Нажатие на кнопку Exit в меню.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Нажатие на кнопку addButton.
        private void addButton_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer(warehouse, customerBindingSource);
            newCustomer.ShowDialog();
        }

        // Нажатие на кнопку deleteButton.
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

        // Нажатие на кнопку newSupplyButton.
        private void newSupplyButton_Click(object sender, EventArgs e)
        {
            NewSupply newSupply = new NewSupply(warehouse, productBindingSource);
            newSupply.ShowDialog();
        }

        // Нажатие на кнопку Change Password в меню.
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPassword newPassword = new NewPassword(warehouse);
            newPassword.ShowDialog();
        }

        // Нажатие на кнопку Save в меню.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse.Save();
        }

        // Нажатие на кнопку confirmButton.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Order)orderBindingSource.Current == null)
                {
                    throw new OrderException("No orders");
                }
                var res = MessageBox.Show("Are you sure you want to confirm this order?", "Confirm", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        warehouse.СonfirmationOfOrder((Order)orderBindingSource.Current);
                        orderBindingSource.ResetBindings(false);
                        productBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            
        }
        // Создание дополнительной колонки в таблице.
        private void orderGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            orderGrid.Rows[e.RowIndex].Cells[0].Value = "Order " + (e.RowIndex + 1).ToString();
        }

        // Нажатие на кнопку detailsButton.
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

        // Нажатие на кнопку salesInvoicesButton.
        private void salesInvoicesButton_Click(object sender, EventArgs e)
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

        // Нажатие на кнопку purchaseInvoicesButton.
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

        // Нажатие на кнопку Inventory в меню.
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(warehouse, productBindingSource);
            inventory.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse.Load();
            productBindingSource.ResetBindings(false);
            orderBindingSource.ResetBindings(false);
            customerBindingSource.ResetBindings(false);
        }
    }
}
