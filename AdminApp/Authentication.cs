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
        //Cоздаем магазин
        Warehouse warehouse = new Warehouse(); 
        public Authentication()
        {
            InitializeComponent();
            //Подгружаем данные
            warehouse.Load(); 
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
            if (warehouse.AuthenticationAdmin(temp_admin))
            {
                Home_Page Home_Page = new Home_Page(warehouse);
                //Отображаем главное меню
                Home_Page.Show();
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
