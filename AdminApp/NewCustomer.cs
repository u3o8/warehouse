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
    public partial class NewCustomer : Form
    {
        Warehouse warehouse;
        BindingSource customerBindingSource;
        public NewCustomer(Warehouse warehouse, BindingSource customerBindingSource)
        {
            InitializeComponent();
            this.warehouse = warehouse;
            this.customerBindingSource = customerBindingSource;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer()
            {
                Login = loginTextBox.Text,
                Adress = adressTextBox.Text,
                Password = passwordTextBox.Text
            };
            warehouse.RegistrationCustomer(newCustomer);
            customerBindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
