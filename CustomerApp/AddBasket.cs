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
    public partial class AddBasket : Form
    {
        Warehouse warehouse;
        Product product;
        BindingSource portionBindingSource;
        public AddBasket(Warehouse warehouse, Product product, BindingSource portionBindingSource)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            this.product = product;
            this.portionBindingSource = portionBindingSource;
            nameTextBox.Text = product.Name;
            idNumericUpDown.Value = product.Id;
            unitTextBox.Text = product.Unit;
            priceNumericUpDown.Value = product.Price;
            amountNumericUpDown.Value = 0;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ((Customer)(warehouse.UserNow)).Basket.Add(new Portion() 
            {
                Product = product,
                Amount = (double)amountNumericUpDown.Value
            });
            portionBindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
