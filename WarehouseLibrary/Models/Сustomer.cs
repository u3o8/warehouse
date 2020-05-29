using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Покупатель - логин + пароль + адрес + история покупок + заказы + корзина.
    //
    [Serializable]
    public class Customer : User
    {
        public string Adress { set; get; }
        public List<Order> History { set; get; }
        public List<Order> Orders { set; get; }
        public List<Portion> Basket { set; get; }

    }
}
