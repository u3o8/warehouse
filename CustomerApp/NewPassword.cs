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

namespace CustomerApp
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
                warehouse.ChangePassword(currentPasswordTextBox.Text, newPasswordTextBox.Text);
                this.Close();
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }
    }
}
