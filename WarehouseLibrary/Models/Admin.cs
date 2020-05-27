using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Admin : User
    {
        public void Copy(Admin admin)
        {
            this.Login = admin.Login;
            this.Password = admin.Password;
        }
    }
}
