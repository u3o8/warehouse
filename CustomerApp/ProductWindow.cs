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
    public partial class ProductWindow : Form
    {
        protected Warehouse warehouse;
        protected BindingSource portionBindingSource;
        protected Product product;

        public ProductWindow()
        {
            InitializeComponent();
        }
        public ProductWindow(Warehouse warehouse, Product product, BindingSource portionBindingSource)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            this.product = product;
            this.portionBindingSource = portionBindingSource;
            nameTextBox.Text = product.Name;
            idNumericUpDown.Value = product.Id;
            unitTextBox.Text = product.Unit;
            priceNumericUpDown.Value = product.Price;
        }

        protected virtual void confirmButton_Click(object sender, EventArgs e)
        {
            portionBindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
