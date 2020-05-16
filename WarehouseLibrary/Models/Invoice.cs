using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Invoice
    {
        public DateTime DateTime { set; get; }
        public List<Product> Products;
    }
}
