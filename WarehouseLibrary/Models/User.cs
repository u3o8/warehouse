using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public abstract class User
    {
        public string Login { set; get; }
        public string Password { set; get; }

        //Для валидации юзеров будем использовать сравнения
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            User cust = (User)obj;
            return (this.Login == cust.Login) && (this.Password == cust.Password);
        }
        public override int GetHashCode()
        {
            return 1;
        }

    }
}
