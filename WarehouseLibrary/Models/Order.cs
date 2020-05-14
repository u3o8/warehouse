using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    public class Order
    {
        public List<Product> Products;
        public Customer Customer { set; get; }
        public DateTime Date { set; get; }
    }
}
