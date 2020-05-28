﻿using System;
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
            warehouse.Load();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Создаем пользователя для проверки его в списке существующих
            Customer tempCustomer = new Customer() 
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text
            };
            //Проверяем
            if (warehouse.AuthenticationCustomer(tempCustomer))
            {
                HomePage homePage = new HomePage(warehouse);
                //Отображаем главное меню
                homePage.Show();
                //Скрываем аутентификацию
                this.Hide();
            }
            else
            {
                //Выводим сообщение об ошибки ввода
                MessageBox.Show("You have entered your password or account name incorrectly. Please check your password and account name and try again.", "Authentication");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }
    }
}
