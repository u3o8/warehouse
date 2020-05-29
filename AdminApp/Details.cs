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
    // Форма для получения дополнительной информации о заказе.
    //
    public partial class Details : Form
    {
        Warehouse warehouse;
        Order order;
        public Details(Warehouse warehouse, Order order)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            this.order = order;
            portionBindingSource.DataSource = order.Portions;
            GetInfo();
        }

        // Действие при нажатии на продукт в нашей сетке. 
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
    }
}
