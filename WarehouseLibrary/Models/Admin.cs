using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Администратор - логин + пароль.
    //
    [Serializable]
    public class Admin : User
    {
        // Метод для копирования администратора.
        public void Copy(Admin admin)
        {
            this.Login = admin.Login;
            this.Password = admin.Password;
        }

    }
}
