using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Product
    {
        public string Name { set; get; }
        public int Id { set; get; } //Артикул друgими словами
        public string Unit { set; get; }
        public decimal Price { set; get; }
        public string Amount { set; get; }
        public DateTime DateTime { set; get; }

    }
}
