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

        private void button_OK_Click(object sender, EventArgs e)
        {
            //Создаем пользователя для проверки его в списке существующих
            Customer temp_customer = new Customer() {
                Login = textbox_Login.Text,
                Password = textbox_Password.Text
            };
            //Проверяем
            if (warehouse.Customer_Authentication(temp_customer))
            {
                Form Home_page = new Form();
                Home_page.Show(); //Отображаем главное меню
                this.Hide(); //Скрываем аутентификацию
            }
            else
                //Выводим сообщение об ошибки ввода
                MessageBox.Show("You have entered your password or account name incorrectly. Please check your password and account name and try again.", "Authentication");
        }
    }
}
