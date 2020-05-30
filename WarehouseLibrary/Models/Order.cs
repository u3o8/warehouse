using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Заказ - коллекция порций + покупатель + дата + суммарная стоимость.
    // Также создано поле для получения логина покупателя напрямую. 
    //
    [Serializable]
    public class Order
    {
        public Order(List<Portion> portions, Customer buyer, decimal totalPrice)
        {
            Portions = portions;
            Customer = buyer;
            DateTime = DateTime.Now;
            TotalPrice = totalPrice;
        }
        public DateTime DateTime { set; get; }
        public List<Portion> Portions { private set; get; }
        public Customer Customer { private set; get; }
        public decimal TotalPrice { private set; get; }

        // Поле для получения логина покупателя напрямую. 
        public string CustomerLogin { get => Customer.Login; }

    }
}
