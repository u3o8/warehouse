using System;
using System.Collections.Generic;
using System.Text;
using WarehouseLibrary.DAL;
using WarehouseLibrary.My_Exceptions;

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

        //Подтверждение пользователя,переместилось сюда
        //в отличии от написанного в спецификации, однако
        //в классе перегружен метод сравнения
        public bool Validation(Customer enter) {
            foreach (Customer customer in Customers) //перебор всех пользовтелей
                if (customer.Equals(enter)) //если нашли пользователя, то происходит вход в учетную запись
                    return true;
            return false; //если не нашли в нашем списке подходящего пользовтеля, то что-то ввели не так
        }

        //Регистрация клиента
        public void Registration(Customer new_customer) {
            foreach (Customer customer in Customers) //перебор всех пользовтелей
                if (customer.Login == new_customer.Login) //если нашли данный логин, то он занят
                    throw new LoginException("Invalid login!"); //потом словим данное исключение
            Customers.Add(new_customer); //если нет такого логина, то спокойно регистрируем пользователя
        }

        //Учет поставки
        public void Supply(Purchase_Invoice new_supply) {
            Purchase_Invoices.Add(new_supply); //добавляем нашу поставку
            List<Product> new_products = new_supply.Product_from_Supply(); //для добавления в магазин извлекаем продукты из поставки
            //мы могли бы просто добавить продукты, однако давайте подумаем о том, что определенный продукт может быть уже в магазине
            //тогда нужно будет увеличить количество, а не иметь два разных продукта
            foreach (Product new_product in new_products) {
                bool key = false; //указывает, что товара на складе нет
                foreach (Product temp in Products) {
                    if (new_product.Equals(temp))
                    {
                        key = true; //указываем, что товар есть на складе, данный товар мы уже не будем добавлять
                        temp.Amount += new_product.Amount; //если уже имеем данный продукт на складе, то просто меняем количество
                        break;
                    }
                }
                if (key == false)
                    Products.Add(new_product); //тут добавляем
            }
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
