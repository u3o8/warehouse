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
    public partial class Authentication : Form
    {
        Warehouse warehouse = new Warehouse();
        public Authentication()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Создаем пользователя для проверки его в списке существующих
            Customer temp_customer = new Customer() 
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text
            };
            //Проверяем
            if (warehouse.AuthenticationCustomer(temp_customer))
            {
                Form Home_page = new Form();
                //Отображаем главное меню
                Home_page.Show();
                //Скрываем аутентификацию
                this.Hide();
            }
            else
            {
                //Выводим сообщение об ошибки ввода
                MessageBox.Show("You have entered your password or account name incorrectly. Please check your password and account name and try again.", "Authentication");
            }
        }
    }
}
