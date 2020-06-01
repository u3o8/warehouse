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
    // Форма добавления пользователя.
    //
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

        // Действие при нажатии на кнопку confirmButton.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer()
            {
                Login = loginTextBox.Text,
                Adress = adressTextBox.Text,
                Password = passwordTextBox.Text
            };
            try
            {
                try
                {
                    warehouse.RegistrationCustomer(newCustomer);
                    customerBindingSource.ResetBindings(false);
                    this.Close();
                }
                catch (LoginException ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            
        }
    }
}
