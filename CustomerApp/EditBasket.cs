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
    public partial class EditBasket : ProductWindow
    {
        Portion portion;
        public EditBasket(Warehouse warehouse, Portion portion, BindingSource portionBindingSource) : base(warehouse, portion.Product, portionBindingSource)
        {
            InitializeComponent();
            textLabel.Text = "Edit product";
            this.portion = portion;
            amountNumericUpDown.Value = (decimal)portion.Amount;
        }

        protected override void confirmButton_Click(object sender, EventArgs e)
        {
            portion.Amount = (double)amountNumericUpDown.Value;
            base.confirmButton_Click(sender, e);
        }
    }
}

