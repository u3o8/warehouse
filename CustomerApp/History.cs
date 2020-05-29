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
    // Форма для отображения истории заказов.
    //
    public partial class History : Form
    {
        Warehouse warehouse;
        public History(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            orderBindingSource.DataSource = ( (Customer) warehouse.UserNow).History;
            portionBindingSource.DataSource = ((Order)orderBindingSource.Current).Portions;
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

        // Создание дополнительной колонки в таблице.
        private void orderGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            orderGrid.Rows[e.RowIndex].Cells[0].Value = "Order " + (e.RowIndex + 1).ToString();
        }

        // Нажатие на ячейку в сетке orderGrid.
        private void orderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            portionBindingSource.DataSource = ((Order)orderBindingSource.Current).Portions;
            GetInfo();
        }

        // Нажатие на ячейку в сетке productGrid.
        private void productGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfo();
        }

        // Действие при нажатии на кнопку okButton.
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
