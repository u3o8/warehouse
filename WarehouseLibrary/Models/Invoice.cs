using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    public class Invoice
    {
        public DateTime Date { set; get; }
        public List<Product> Products;
    }
}
