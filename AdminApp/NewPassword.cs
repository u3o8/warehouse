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
    // Форма для изменения пароля.
    //
    public partial class NewPassword : Form
    {
        Warehouse warehouse;
        public NewPassword(Warehouse warehouse)
        {
            InitializeComponent();
            this.warehouse = warehouse;
        }

        // Действие при нажатии на кнопку confirmButton.
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                warehouse.ChangePassword(currentPasswordTextBox.Text, newPasswordTextBox.Text);
                this.Close();
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        // Действие при нажатии на кнопку currentPasswordButton.
        private void currentPasswordButton_Click(object sender, EventArgs e)
        {
            currentPasswordTextBox.UseSystemPasswordChar = !currentPasswordTextBox.UseSystemPasswordChar;
        }

        // Действие при нажатии на кнопку newPasswordButton.
        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = !newPasswordTextBox.UseSystemPasswordChar;
        }

        // Действие при нажатии на кнопку cancelButton.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
