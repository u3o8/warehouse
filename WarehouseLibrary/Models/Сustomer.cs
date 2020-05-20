using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Customer : User
    {
        public string Adress { set; get; }

        //Для валидации юзеров будем использовать сравнения
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            Customer cust = (Customer)obj;
            return (this.Login == cust.Login) && (this.Password == cust.Password);
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
