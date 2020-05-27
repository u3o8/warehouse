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
    public partial class EditBasket : Form
    {
        Warehouse warehouse;
        Portion portion;
        BindingSource portionBindingSource;
        public EditBasket(Warehouse warehouse, Portion portion, BindingSource portionBindingSource)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            this.portion = portion;
            this.portionBindingSource = portionBindingSource;
            nameTextBox.Text = portion.Product.Name;
            idNumericUpDown.Value = portion.Product.Id;
            unitTextBox.Text = portion.Product.Unit;
            priceNumericUpDown.Value = portion.Product.Price;
            amountNumericUpDown.Value = (decimal)portion.Amount;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            portion.Amount = (double)amountNumericUpDown.Value;
            portionBindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
