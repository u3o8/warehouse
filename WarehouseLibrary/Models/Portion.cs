using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Portion
    {
        public Product Product { set; get; }
        public double Amount { set; get; }
        public string NameProduct { get => Product.Name; }
    }
}
