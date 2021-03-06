﻿using System;
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
    // Форма для добавления товара в корзину.
    //
    public partial class AddBasket : ProductWindow
    {
        public AddBasket(Warehouse warehouse, Product product, BindingSource portionBindingSource) : base(warehouse, product, portionBindingSource)
        {
            InitializeComponent();
            textLabel.Text = "Add product";
            amountNumericUpDown.Value = 0;
        }

        // Действие при нажатии на кнопку confirmButton.
        protected override void confirmButton_Click(object sender, EventArgs e)
        {
            warehouse.AddBasket(product, (double)amountNumericUpDown.Value);
            base.confirmButton_Click(sender, e);
        }
    }
}