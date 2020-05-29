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
using WarehouseLibrary.My_Exceptions;

namespace AdminApp
{
    // Форма для создания новой поставки.
    //
    public partial class NewSupply : Form
    {
        BindingSource productBindingSource;
        Warehouse warehouse;
        List<Product> tempProducts { get; set; }
        
        public NewSupply(Warehouse warehouse, BindingSource productBindingSource)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            tempProducts = new List<Product>();
            this.productBindingSource = productBindingSource;
            tempProductBindingSource.DataSource = tempProducts;
        }

        // Действие при нажатии на кнопку addButton.
        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = nameTextBox.Text,
                Id = (int)idNumericUpDown.Value,
                Unit = unitTextBox.Text,
                Price = priceNumericUpDown.Value,
                Amount = (double)amountNumericUpDown.Value
            };

            //Проверка на наличие в поставке
            if (!product.CheckProduct(tempProducts))
            {
                tempProducts.Add(product);
            }

            tempProductBindingSource.ResetBindings(false);

        }

        // Действие при нажатии на кнопку confirmButton.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempProducts.Count == 0)
                {
                    throw new SupplyException("No products in supply");
                }
                List<Portion> tempPortions = new List<Portion>();
                foreach (Product product in tempProducts)
                {
                    tempPortions.Add(new Portion()
                    {
                        Product = product,
                        Amount = product.Amount,
                    });
                }
                warehouse.AcountingSupply(new PurchaseInvoice(tempPortions));
                productBindingSource.ResetBindings(false);
                this.Close();
            }
            catch (SupplyException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }
    }
}
