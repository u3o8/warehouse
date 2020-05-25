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
        public Warehouse()
        {
            //Стандартный логин и пароль админа.
            Admin = new Admin()
            {
                Login = "admin",
                Password = "admin",
            };
            Products = new List<Product>();
            Customers = new List<Customer>();
            SalesInvoices = new List<SalesInvoice>();
            PurchaseInvoices = new List<PurchaseInvoice>();
            Orders = new List<Order>();
        }

        public Admin Admin { private set; get; }
        public User UserNow { private set; get; }
        public List<Product> Products { private set; get; }
        public List<Customer> Customers { private set; get; }
        public List<SalesInvoice> SalesInvoices { private set; get; }
        public List<PurchaseInvoice> PurchaseInvoices { private set; get; }
        public List<Order> Orders { private set; get; }

        //Методы.

        public bool AuthenticationCustomer(Customer enter)
        {
            //Перебор всех пользовтелей.
            foreach (Customer customer in Customers)
            {
                //Если пользователь был найден, то происходит вход в учетную запись.
                if (enter.Equals(customer))
                {
                    return true;
                }
            }
            //Если не нашли в нашем списке подходящего пользователя, то что-то было введено не так.
            return false; 
        }

        public bool AuthenticationAdmin(Admin enter)
        {
            if (enter.Equals(Admin))
            {
                return true;
            }
            //Если не нашли в нашем списке подходящего пользовтеля, то что-то ввели не так.
            return false; 
        }

        //Регистрация клиента
        public void RegistrationCustomer(Customer newCustomer) 
        {
            //Перебор всех пользователей.
            foreach (Customer customer in Customers) 
            {
                //Если нашли данный логин, то он занят.
                if (customer.Login == newCustomer.Login) 
                {
                    throw new LoginException("Invalid login!");
                }
            }
            //Если нет такого логина, то спокойно регистрируем пользователя.
            Customers.Add(newCustomer); 
        }

        //Учет поставки
        public void AcountingSupply(PurchaseInvoice newSupply) 
        {
            PurchaseInvoices.Add(newSupply);
            //Для добавления в магазин извлекаем продукты из поставки.
            List<Product> newProducts = newSupply.GetProductFromInvoice(); 
            //Мы могли бы просто добавить продукты, однако давайте подумаем о том, что определенный продукт может быть уже в магазине,
            //тогда нужно будет увеличить количество, а не иметь два разных продукта.
            foreach (Product newProduct in newProducts) 
            {
                //Указывает, что товара на складе нет.
                bool key = false; 
                foreach (Product temp in Products) 
                {
                    if (newProduct.Equals(temp))
                    {
                        //Указываем, что товар есть на складе,
                        //данный товар мы уже не будем добавлять.
                        key = true;
                        //Если уже имеем данный продукт на складе, 
                        //то просто меняем количество.
                        temp.Amount += newProduct.Amount; 
                        break;
                    }
                }
                if (key == false)
                {
                    Products.Add(newProduct); 
                }
            }
        }

        //Создание заказа.
        public void CreateNewOrder(List<Portion> portionForOrder) 
        {
            Order newOrder = new Order(portionForOrder, (Customer)UserNow); 
            Orders.Add(newOrder); 
        }

        public void Сonfirmation_of_order(Order targetOrder)
        {
            //Cоздаем расходную накладную.
            SalesInvoice temp = new SalesInvoice (targetOrder.Portions, targetOrder.Customer);
            //Проверяем хватает ли на складе продуктов.

            //Извлекаем продукты.
            List<Product> checkProducts = temp.GetProductFromInvoice();
            //Для понимания, можем принять заказ или нет.
            bool key = true; 
            foreach (Product targetCheckProduct in checkProducts){
                bool find = false;
                foreach (Product productWarehouse in Products)
                {
                    //Находим продукт в списке.
                    if (targetCheckProduct.Equals(productWarehouse)) 
                    {
                        find = true;
                        //Не хватает? Заказ принять не можем.
                        if (productWarehouse.Amount < targetCheckProduct.Amount) 
                        {
                            key = false;
                        }
                        break;
                    }
                    //Не нашли продукт? Не можем заказ принять.
                    if (find == false) 
                    { 
                        key = false;
                        break;
                    }
                }
            }

            if (key == false)
                throw new OrderException("Order cannot be approved!");
            //Eсли можем одобрить заказ, то создаем накладную.
            SalesInvoices.Add(temp); 
            //Изменяем количество продуктов
            foreach (Product targetCheckProduct in checkProducts)
            {
                foreach (Product product_warehouse in Products)
                {
                    //Находим продукт в списке.
                    if (targetCheckProduct.Equals(product_warehouse)) 
                    {
                        //Изменяем количество.
                        product_warehouse.Amount -= targetCheckProduct.Amount;
                        break;
                    }
                }
            }
            //Удаляем заказ, т.к. мы его обслужили.
            Orders.Remove(targetOrder); 
        }

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
