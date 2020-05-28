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

namespace CustomerApp
{
    public partial class HomePage : Form
    {
        Warehouse warehouse;
        public HomePage(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            productBindingSource.DataSource = warehouse.Products;
            portionBindingSource.DataSource = ((Customer)warehouse.UserNow).Basket;
            orderBindingSource.DataSource = ((Customer)warehouse.UserNow).Orders;
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

        private void addBasketButton_Click(object sender, EventArgs e)
        {
            var toAddProduct = (Product)productBindingSource.Current;
            AddBasket addBasket = new AddBasket(warehouse, toAddProduct, portionBindingSource);
            addBasket.ShowDialog();
        }

        private void editBasketButton_Click(object sender, EventArgs e)
        {
            var toEditPortion = (Portion)portionBindingSource.Current;
            EditBasket editBasket = new EditBasket(warehouse, toEditPortion, portionBindingSource);
            editBasket.ShowDialog();
        }

        private void deleteBasketButton_Click(object sender, EventArgs e)
        {
            var toDeletePortion = (Portion)portionBindingSource.Current;
            ((Customer)(warehouse.UserNow)).Basket.Remove(toDeletePortion);
            portionBindingSource.ResetBindings(false);
        }

        private void orderGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            orderGrid.Rows[e.RowIndex].Cells[0].Value = "Order " + (e.RowIndex + 1).ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Customer)(warehouse.UserNow)).Basket.Count == 0)
                {
                    throw new OrderException("There are no products in the basket");
                }
                warehouse.CreateNewOrder();
                portionBindingSource.DataSource = ((Customer)warehouse.UserNow).Basket;
                orderBindingSource.ResetBindings(false);
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            var toDeleteOrder = (Order)orderBindingSource.Current;
            warehouse.DeleteOrder(toDeleteOrder);
            orderBindingSource.ResetBindings(false);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse.Save();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPassword newPassword = new NewPassword(warehouse);
            newPassword.ShowDialog();
        }

        private void checkHistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Customer)warehouse.UserNow).History.Count == 0)
                {
                    throw new OrderException("No order history");
                }
                History history = new History(warehouse);
                history.ShowDialog();
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (warehouse.Orders.Count == 0)
                {
                    throw new OrderException("There are no orders");
                }
                AboutOrder aboutOrder = new AboutOrder(warehouse, (Order)orderBindingSource.Current);
                aboutOrder.ShowDialog();
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your login: " + ((Customer)warehouse.UserNow).Login + "\n" +
                "Your adress: " + ((Customer)warehouse.UserNow).Adress + "\n" +
                "If you need to change your login/adress/password - " +
                "contact administrator");
        }
    }
}
