using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Purchase_Invoice : Invoice
    {
        //Methods
        public List<Product> Product_from_Supply() {
            List<Product> new_products = new List<Product>();
            for (int i = 0; i < this.Portions.Count; ++i)
            {
                //составляю новые продукты
                Product temp = new Product()
                {
                    Name = this.Portions[i].Product.Name, 
                    Id = this.Portions[i].Product.Id, 
                    Unit = this.Portions[i].Product.Unit,
                    Price = this.Portions[i].Product.Price,
                    Amount = this.Portions[i].Amount
                };
                new_products.Add(temp);
            }
            return new_products;
        }
    }
}
