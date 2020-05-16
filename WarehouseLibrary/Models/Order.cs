using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Order
    {
        public Order(List<Portion> portions, Customer buyer)
        {
            Portions = portions;
            Customer = buyer;
            DateTime = DateTime.Now;
        }
        public List<Portion> Portions { private set; get; }
        public Customer Customer { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}
