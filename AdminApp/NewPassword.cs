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
    public partial class NewPassword : Form
    {
        Warehouse warehouse;
        public NewPassword(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                warehouse.CheckPassword(newPasswordTextBox.Text);
                warehouse.ChangePassword(currentPasswordTextBox.Text, newPasswordTextBox.Text);
                this.Close();
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void currentPasswordButton_Click(object sender, EventArgs e)
        {
            currentPasswordTextBox.UseSystemPasswordChar = !currentPasswordTextBox.UseSystemPasswordChar;
        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = !newPasswordTextBox.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
