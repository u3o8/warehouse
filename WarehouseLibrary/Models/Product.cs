using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    public class Product
    {
        public string Name { set; get; }
        public string Id { set; get; } //Артикул друшими словами
        public string Unit { set; get; }
        public decimal Price { set; get; }
        public string Amount { set; get; }
        public Data_struct Data { set; get; }

    }
}
