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
        public Admin Admin { private set; get; }
        public User User_now { private set; get; }
        public List<Product> Products { private set; get; }
        public List<Customer> Customers { private set; get; }
        public List<Sales_Invoice> Sales_Invoices { private set; get; }
        public List<Purchase_Invoice> Purchase_Invoices { private set; get; }
        public List<Order> Orders { private set; get; }
        public Warehouse()
        {
            //Стандартный логин и пароль админа. Создадим потом возможность изменять данные параметры
            Admin = new Admin() {
                Login = "admin",
                Password = "admin",
            };
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
        public bool Customer_Authentication(Customer enter) {
            foreach (Customer customer in Customers) //перебор всех пользовтелей
                if (enter.Equals(customer)) //если нашли пользователя, то происходит вход в учетную запись
                    return true;
            return false; //если не нашли в нашем списке подходящего пользовтеля, то что-то ввели не так
        }

        public bool Admin_Authentication(Admin enter)
        {
            if (enter.Equals(Admin))
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
            List<Product> new_products = new_supply.Product_from_Invoice(); //для добавления в магазин извлекаем продукты из поставки
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

        //Создание заказа
        public void New_Order(List<Portion> portion_for_order) {
            Order new_order = new Order(portion_for_order, (Customer)User_now); //создаю конструктором
            Orders.Add(new_order); //добавляю в заказы
        }

        public void Сonfirmation_of_order(Order target_order) {
            Sales_Invoice temp = new Sales_Invoice (target_order.Portions, target_order.Customer); //создаем расходную накладную
            //Проверяем хватает ли на складе продуктов
            List<Product> check_products = temp.Product_from_Invoice(); //извлекаем продукты
            bool key = true; //для понимания, можем принять заказ или нет
            foreach (Product target_check_product in check_products){
                bool find = false;
                foreach (Product product_warehouse in Products)
                {
                    if (target_check_product.Equals(product_warehouse)) //Находим продукт в списке
                    {
                        find = true;
                        if (product_warehouse.Amount < target_check_product.Amount) //Не хватает? Заказ принять не можем
                            key = false;
                        break;
                    }
                    if (find == false)
                    { //Не нашли продукт? Не можем заказ принять
                        key = false;
                        break;
                    }
                }
            }

            if (key == false)
                throw new OrderException("Order cannot be approved!"); //вырабатываем исключение
            Sales_Invoices.Add(temp); //если можем одобрить заказ, то создаем накладную
            //Изменяем количество продуктов
            foreach (Product target_check_product in check_products)
            {
                foreach (Product product_warehouse in Products)
                {
                    if (target_check_product.Equals(product_warehouse)) //Находим продукт в списке
                    {
                        product_warehouse.Amount -= target_check_product.Amount; //изменяем количество
                        break;
                    }
                }
            }
            Orders.Remove(target_order); //удаляем заказ, ибо мы его обслужили
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
