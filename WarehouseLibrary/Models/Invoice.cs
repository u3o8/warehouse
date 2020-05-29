using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Накладная - это это коллекция порций + дата.
    //
    [Serializable]
    public class Invoice
    {
        // Конструктор.
        public Invoice (List<Portion> portions) 
        {
            Portions = portions;
            DateTime = DateTime.Now;
        }

        public DateTime DateTime { set; get; }
        public List<Portion> Portions { set; get; }

        // Метод для получения продуктов из накладной.
        // Возращает соответсвенно продукты.
        public List<Product> GetProductFromInvoice()
        {
            // В данное место мы поместим наши новые продукты.
            List<Product> newProducts = new List<Product>(); 
            for (int i = 0; i < this.Portions.Count; ++i)
            {
                // Составляю новые продукты.
                Product temp = new Product()
                {
                    Name = this.Portions[i].Product.Name,
                    Id = this.Portions[i].Product.Id,
                    Unit = this.Portions[i].Product.Unit,
                    Price = this.Portions[i].Product.Price,
                    Amount = this.Portions[i].Amount,
                    DateTime = this.Portions[i].Product.DateTime
                };
                newProducts.Add(temp);
            }
            return newProducts;
        }


    }
}
