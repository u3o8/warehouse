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
    public partial class Authentication : Form
    {
        Warehouse warehouse = new Warehouse(); //создаем магазин
        public Authentication()
        {
            InitializeComponent();
            warehouse.Load(); //подгружаем данные
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Создаем пользователя для проверки его в списке существующих
            Admin temp_admin = new Admin()
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text
            };
            //Проверяем
            if (warehouse.Admin_Authentication(temp_admin))
            {
                Home_Page Home_Page = new Home_Page(warehouse);
                Home_Page.Show(); //Отображаем главное меню
                this.Hide(); //Скрываем аутентификацию
            }
            else
                //Выводим сообщение об ошибки ввода
                MessageBox.Show("You have entered your password or account name incorrectly. Please check your password and account name and try again.", "Authentication");
        }
    }
}
