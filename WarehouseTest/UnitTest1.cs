using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLibrary.Models;
using WarehouseLibrary.My_Exceptions;

namespace WarehouseTest
{
    [TestClass]
    public class Test_Supply
    {
        [TestMethod]
        public void Test_Supply_Load_Save()
        {
            const int n = 100;
            Warehouse warehouse = new Warehouse(); 
            List<Portion> test_portions = new List<Portion>(); //создаю тестовые порции, т.к. поставка порция + дата
            for (int i = 0; i < n; i++)
            {
                //создаю продукт, который является частью класса порция
                Product new_product = new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = i * 10,
                    Unit = "kg"
                };
                //после этого создаю саму порцию
                test_portions.Add(new Portion()
                {
                    Product = new_product,
                    Amount = (i + 3) * 2
                });
            }
            warehouse.Supply(new Purchase_Invoice(test_portions));
            Assert.AreEqual("Product0", warehouse.Products[0].Name);
            Assert.AreEqual("Product99", warehouse.Products[99].Name);
            Assert.AreEqual("Product22", warehouse.Products[22].Name);
            Assert.AreEqual(8, warehouse.Products[8].Id);
            Assert.AreEqual("kg", warehouse.Products[84].Unit);
            Assert.AreEqual(80, warehouse.Products[8].Price);
            Assert.IsNotNull(warehouse.Purchase_Invoices);

            warehouse.Save(); //а это в файле чек
            warehouse.Load();

            Assert.AreEqual(8, warehouse.Products[8].Id);
            Assert.AreEqual("kg", warehouse.Products[84].Unit);


        }

        [TestMethod]
        public void Test_Supply_the_same() {
            const int n = 100;
            Warehouse warehouse = new Warehouse();
            List<Portion> test_portions = new List<Portion>(); //создаю тестовые порции, т.к. поставка порция + дата
            for (int i = 0; i < n; i++)
            {
                //создаю продукт, который является частью класса порция
                Product new_product = new Product()
                {
                    Id = 12345678,
                    Name = $"Product 34",
                    Price = 228,
                    Unit = "kg"
                };
                //после этого создаю саму порцию
                test_portions.Add(new Portion()
                {
                    Product = new_product,
                    Amount = 5
                });
            }
            warehouse.Supply(new Purchase_Invoice(test_portions));
            Assert.AreEqual("Product 34", warehouse.Products[0].Name);
            Assert.AreEqual(500, warehouse.Products[0].Amount);
        }
    }
    [TestClass]
    public class Test_User
    {
        [TestMethod]
        public void Test_new_Users() {
            Warehouse warehouse = new Warehouse();
            const int n = 7;
            List<Customer> test_customers = new List<Customer>();
            for (int i = 0; i < n; i++)
                warehouse.Registration(new Customer { Login = $"Customer{i}", Password = "123", Adress = "234@cust.com" });
            Assert.AreEqual("Customer6", warehouse.Customers[6].Login);
            Assert.AreEqual("Customer2", warehouse.Customers[2].Login);
            Assert.AreEqual("123", warehouse.Customers[0].Password);
        }

        [TestMethod]
        [ExpectedException(typeof(LoginException),
            "Invalid login!")]
        public void Test_Exception() {
            Warehouse warehouse = new Warehouse();
            const int n = 7;
            List<Customer> test_customers = new List<Customer>();
            for (int i = 0; i < n; i++)
                warehouse.Registration(new Customer { Login = $"Login", Password = "123", Adress = "l@cust.com" });
        }

        [TestMethod]
        public void Test_authentication() {
            Warehouse warehouse = new Warehouse();
            const int n = 2;
            List<Customer> test_customers = new List<Customer>();
            for (int i = 0; i < n; i++)
                warehouse.Registration(new Customer { Login = $"Customer{i}", Password = "123", Adress = "234@cust.com" });
            Assert.IsTrue(warehouse.Customer_Authentication(new Customer { Login = "Customer0", Password = "123" }));
            Assert.IsTrue(warehouse.Customer_Authentication(new Customer { Login = "Customer1", Password = "123" }));
            Assert.IsFalse(warehouse.Customer_Authentication(new Customer { Login = "Customer0", Password = "143" }));
            Assert.IsFalse(warehouse.Customer_Authentication(new Customer { Login = "Customer33", Password = "123" }));
        }
    }

 }
