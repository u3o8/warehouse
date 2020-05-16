using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Warehouse
    {
        public List<Product> Products { private set; get; }
        public List<Customer> Customers { private set; get; }
        public List<Sales_Invoice> Sales_Invoices { private set; get; }
        public List<Purchase_Invoice> Purchase_Invoices { private set; get; }
        //Покупатели active будут, а пока так
        public List<Order> Orders { private set; get; }
        public Warehouse()
        {
            Products = new List<Product>();
            Customers = new List<Customer>();
            Sales_Invoices = new List<Sales_Invoice>();
            Purchase_Invoices = new List<Purchase_Invoice>();
            Orders = new List<Order>();
        }


    }
}
