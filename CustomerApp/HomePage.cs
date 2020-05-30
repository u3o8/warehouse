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
            portionBindingSource.DataSource = ((Customer)warehouse.UserNow).Basket;
            orderBindingSource.DataSource = ((Customer)warehouse.UserNow).Orders;
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

        // Нажатие на кнопку addBasketButton.
        private void addBasketButton_Click(object sender, EventArgs e)
        {
            var toAddProduct = (Product)productBindingSource.Current;
            AddBasket addBasket = new AddBasket(warehouse, toAddProduct, portionBindingSource);
            addBasket.ShowDialog();
        }

        // Нажатие на кнопку editBasketButton.
        private void editBasketButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Customer)(warehouse.UserNow)).Basket.Count == 0)
                {
                    throw new OrderException("Nothing to edit");
                }
                var toEditPortion = (Portion)portionBindingSource.Current;
                EditBasket editBasket = new EditBasket(warehouse, toEditPortion, portionBindingSource);
                editBasket.ShowDialog();
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        // Нажатие на кнопку deleteBasketButton.
        private void deleteBasketButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Customer)(warehouse.UserNow)).Basket.Count == 0)
                {
                    throw new OrderException("Nothing to delete");
                }
                var toDeletePortion = (Portion)portionBindingSource.Current;
                if (toDeletePortion != null)
                {
                    var res = MessageBox.Show("Are you sure you want to delete this product?", "Delete", MessageBoxButtons.YesNo);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            ((Customer)(warehouse.UserNow)).Basket.Remove(toDeletePortion);
                            portionBindingSource.ResetBindings(false);
                            break;
                        case DialogResult.No:
                            break;
                    }
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

        // Нажатие на кнопку confirmButton.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Customer)(warehouse.UserNow)).Basket.Count == 0)
                {
                    throw new OrderException("There are no products in the basket");
                }
                decimal total = warehouse.GetTotal();
                var res = MessageBox.Show("Total price: " + total + "\n" + "Do you want to make an order?", "Order", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        throw new OrderException("Order cancellation");
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

        // Нажатие на кнопку deleteOrderButton.
        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Customer)(warehouse.UserNow)).Orders.Count == 0)
                {
                    throw new OrderException("Nothing to delete");
                }
                var toDeleteOrder = (Order)orderBindingSource.Current;
                if (toDeleteOrder != null)
                {
                    var res = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            warehouse.DeleteOrder(toDeleteOrder);
                            orderBindingSource.ResetBindings(false);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
            catch (OrderException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        // Нажатие на кнопку Save в меню.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse.Save();
        }


        // Нажатие на кнопку checkHistoryButton.
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

        // Нажатие на кнопку aboutButton.
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

        // Нажатие на кнопку Exit в меню.
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Нажатие на кнопку About в меню.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your login: " + ((Customer)warehouse.UserNow).Login + "\n" +
                "Your adress: " + ((Customer)warehouse.UserNow).Adress + "\n" +
                "If you need to change your login/adress/password - " +
                "contact administrator");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse.Load();
            productBindingSource.ResetBindings(false);
            orderBindingSource.ResetBindings(false);
            portionBindingSource.ResetBindings(false);
        }
    }
}
