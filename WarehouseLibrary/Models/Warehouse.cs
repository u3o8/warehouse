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

        //Подтверждение администратора при входе.
        public bool AuthenticationAdmin(Admin enter)
        {
            if (enter.Equals(Admin))
            {
                //Назначили текущего пользователя
                this.UserNow = Admin;
                return true;
            }
            //Если не нашли в нашем списке подходящего пользовтеля, то что-то ввели не так.
            return false;
        }

        //Подтверждение пользователя при входе.
        public bool AuthenticationCustomer(Customer enter)
        {
            //Перебор всех пользователей.
            foreach (Customer customer in Customers)
            {
                //Если пользователь был найден, то происходит вход в учетную запись.
                if (enter.Equals(customer))
                {
                    //Назначили текущего пользователя
                    this.UserNow = customer;
                    return true;
                }
            }
            //Если не нашли в нашем списке подходящего пользователя, то что-то было введено не так.
            return false; 
        }

        //Регистрация клиента.
        public void RegistrationCustomer(Customer newCustomer) 
        {
            //Пользователь не может взять логин администратора.
            if (newCustomer.Login == "Admin")
            {
                throw new LoginException("Invalid login!");
            }
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
            newCustomer.Orders = new List<Order>();
            newCustomer.Basket = new List<Portion>();
            Customers.Add(newCustomer); 
        }

        //Изменение пароля администратора
        public void ChangeAdminPassword(string newPassword) {
            Admin.Password = newPassword;
        }

        //Учет поставки.
        public void AcountingSupply(PurchaseInvoice newSupply) 
        {
            PurchaseInvoices.Add(newSupply);
            //Для добавления в магазин извлекаем продукты из поставки.
            List<Product> newProducts = newSupply.GetProductFromInvoice(); 
            //Мы могли бы просто добавить продукты, однако давайте подумаем о том, что определенный продукт может быть уже в магазине,
            //тогда нужно будет увеличить количество, а не иметь два разных продукта.
            foreach (Product newProduct in newProducts) 
            {
                if (!newProduct.CheckProduct(Products))
                {
                    Products.Add(newProduct); 
                }
            }
        }

        //Составление заказа
        public void СhooseProduct(Portion newPortion) 
        {
            List<Portion> portions = ((Customer)UserNow).Basket;
            foreach (Portion portion in portions)
            {
                if ((newPortion.Product).Equals(portion.Product))
                {
                    portion.Amount += newPortion.Amount;
                    return;
                }
            }
            portions.Add(newPortion);
        }

        //Создание заказа.
        public void CreateNewOrder() 
        {
            List<Portion> portionForOrder = ((Customer)(this.UserNow)).Basket;
            Order newOrder = new Order(portionForOrder, (Customer)UserNow); 
            Orders.Add(newOrder);
            ((Customer)(this.UserNow)).Orders.Add(newOrder);
        }

        //Удаление заказа.
        public void DeleteOrder(Order order)
        {
            Customer customer = order.Customer;
            foreach (Order customerOrder in customer.Orders)
            {
                if (customerOrder == order)
                {
                    customer.Orders.Remove(order);
                    break;
                }
            }
            Orders.Remove(order);
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
