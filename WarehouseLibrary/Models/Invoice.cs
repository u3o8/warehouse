using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Invoice
    {
        public Invoice (List<Portion> portions) 
        {
            Portions = portions;
            DateTime = DateTime.Now;
        }
        public DateTime DateTime { set; get; }
        public List<Portion> Portions { set; get; }

        //Методы.
        public List<Product> GetProductFromInvoice()
        {
            //В данное место мы поместим наши новые продукты.
            List<Product> newProducts = new List<Product>(); 
            for (int i = 0; i < this.Portions.Count; ++i)
            {
                //Составляю новые продукты.
                Product temp = new Product()
                {
                    Name = this.Portions[i].Product.Name,
                    Id = this.Portions[i].Product.Id,
                    Unit = this.Portions[i].Product.Unit,
                    Price = this.Portions[i].Product.Price,
                    Amount = this.Portions[i].Amount
                };
                newProducts.Add(temp);
            }
            return newProducts;
        }

    }
}
