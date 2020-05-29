using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Пользователь - логин + пароль.
    //
    [Serializable]
    public abstract class User
    {
        public string Login { set; get; }
        public string Password { set; get; }

        // Для валидации пользователей будем использовать сравнения. 
        // Поэтому перегрузим метод Equals().
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            User cust = (User)obj;
            return (this.Login == cust.Login) && (this.Password == cust.Password);
        }

        // Поскольку перегрузили метод Equals(), то нужно перегрузить и GetHashCode().
        public override int GetHashCode()
        {
            return 1;
        }

    }
}
