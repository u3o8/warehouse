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

namespace CustomerApp
{
    // Форма для вывода информации о заказе.
    //
    public partial class AboutOrder : Form
    {
        Warehouse warehouse;
        Order order;
        public AboutOrder(Warehouse warehouse, Order order)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            this.order = order;
            portionBindingSource.DataSource = order.Portions;
            GetInfo();
        }

        // Нажатие на ячейку в сетке productGrid.
        private void productGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfo();
        }

        // Метод для вывода дополнительной информации.
        private void GetInfo()
        {
            Portion portion = (Portion)portionBindingSource.Current;
            nameTextBox.Text = portion.Product.Name;
            idNumericUpDown.Value = portion.Product.Id;
            unitTextBox.Text = portion.Product.Unit;
            priceNumericUpDown.Value = portion.Product.Price;
            amountNumericUpDown.Value = (decimal)portion.Amount;
        }

        // Действие при нажатии на кнопку okButton.
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
