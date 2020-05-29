using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Порция - продукт + количество.
    // Также было создано поле для получения названия товара напрямую.
    //
    [Serializable]
    public class Portion
    {
        public Product Product { set; get; }
        public double Amount { set; get; }

        // Поле для получения названия товара напрямую.
        public string NameProduct { get => Product.Name; }

    }
}
