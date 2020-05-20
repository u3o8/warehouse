using System;
using System.Collections.Generic;
using System.Text;
using WarehouseLibrary.DAL;

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

        //Methods

        //Регистрация клиента
        public void Registration(Customer new_customer) {
            Customers.Add(new_customer);
        }

        //Учет поставки
        public void Supply(Purchase_Invoice new_supply) {
            Purchase_Invoices.Add(new_supply);
            List<Product> new_products = new_supply.Product_from_Supply();
            Products.AddRange(new_products);
        }
        //////////////////////
        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
