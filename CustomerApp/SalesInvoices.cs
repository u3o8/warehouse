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
    // Форма для отображения расходной накладной.
    //
    public partial class SalesInvoices : Form
    {
        Warehouse warehouse;
        public SalesInvoices(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            salesInvoiceBindingSource.DataSource = warehouse.SalesInvoices;
            portionBindingSource.DataSource = ((SalesInvoice)salesInvoiceBindingSource.Current).Portions;
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
        private void invoiceGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            invoiceGrid.Rows[e.RowIndex].Cells[0].Value = "Invoice " + (e.RowIndex + 1).ToString();
        }

        // Нажатие на ячейку в сетке invoiceGrid.
        private void invoiceGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            portionBindingSource.DataSource = ((SalesInvoice)salesInvoiceBindingSource.Current).Portions;
            GetInfo();
        }

        // Нажатие на ячейку в сетке portionGrid.
        private void portionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfo();
        }
    }
}
