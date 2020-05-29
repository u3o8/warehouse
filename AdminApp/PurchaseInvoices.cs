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
    // Форма для отображения приходной накладной.
    //
    public partial class PurchaseInvoices : Form
    {
        Warehouse warehouse;
        public PurchaseInvoices(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            purchaseInvoiceBindingSource.DataSource = warehouse.PurchaseInvoices;
            portionBindingSource.DataSource = ((PurchaseInvoice)purchaseInvoiceBindingSource.Current).Portions;
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
            invoiceGrid.Rows[e.RowIndex].Cells[0].Value = "Purchase Invoice " + (e.RowIndex + 1).ToString();
        }

        // Нажатие на ячейку в сетке invoiceGrid.
        private void invoiceGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            portionBindingSource.DataSource = ((PurchaseInvoice)purchaseInvoiceBindingSource.Current).Portions;
            GetInfo();
        }

        // Нажатие на ячейку в сетке portionGrid.
        private void portionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfo();
        }
    }
}
