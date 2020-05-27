using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLibrary.Models;
using WarehouseLibrary.My_Exceptions;

namespace WarehouseTest
{
    [TestClass]
    public class TestSupply
    {
        [TestMethod]
        public void TestSupplyLoadSave()
        {
            const int n = 100;
            Warehouse warehouse = new Warehouse();
            //Cоздаю тестовые порции, т.к. поставка порция + дата
            List<Portion> testPortions = new List<Portion>(); 
            for (int i = 0; i < n; i++)
            {
                //Cоздаю продукт, который является частью класса порция
                Product newProduct = new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = i * 10,
                    Unit = "kg",
                    DateTime = DateTime.Now
                };
                //После этого создаю саму порцию
                testPortions.Add(new Portion()
                {
                    Product = newProduct,
                    Amount = (i + 3) * 2
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));
            Assert.AreEqual("Product0", warehouse.Products[0].Name);
            Assert.AreEqual("Product99", warehouse.Products[99].Name);
            Assert.AreEqual("Product22", warehouse.Products[22].Name);
            Assert.AreEqual(8, warehouse.Products[8].Id);
            Assert.AreEqual("kg", warehouse.Products[84].Unit);
            Assert.AreEqual(80, warehouse.Products[8].Price);
            Assert.IsNotNull(warehouse.PurchaseInvoices);

            //Проверяем в файле
            warehouse.Save(); 
            warehouse.Load();

            Assert.AreEqual(8, warehouse.Products[8].Id);
            Assert.AreEqual("kg", warehouse.Products[84].Unit);


        }

        [TestMethod]
        public void TestSupplyTheSame() 
        {
            const int n = 100;
            Warehouse warehouse = new Warehouse();
            //Cоздаю тестовые порции, т.к. поставка порция + дата
            List<Portion> testPortions = new List<Portion>(); 
            for (int i = 0; i < n; i++)
            {
                //Cоздаю продукт, который является частью класса порция
                Product new_product = new Product()
                {
                    Id = 12345678,
                    Name = $"Product 34",
                    Price = 228,
                    Unit = "kg",
                    DateTime = DateTime.Now,
    };
                //После этого создаю саму порцию
                testPortions.Add(new Portion()
                {
                    Product = new_product,
                    Amount = 5
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));
            Assert.AreEqual("Product 34", warehouse.Products[0].Name);
            Assert.AreEqual(500, warehouse.Products[0].Amount);
        }
    }
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestNewUsers()
        {
            Warehouse warehouse = new Warehouse();
            //warehouse.Save();
            //warehouse.Load();
            const int n = 7;
            for (int i = 0; i < n; i++)
                warehouse.RegistrationCustomer(new Customer() 
                { 
                    Login = $"Customer{i}", 
                    Password = "123", 
                    Adress = "naukova 53" 
                });
            //warehouse.Save();
            //warehouse.Load();
            Assert.AreEqual("Customer6", warehouse.Customers[6].Login);
            Assert.AreEqual("Customer2", warehouse.Customers[2].Login);
            Assert.AreEqual("123", warehouse.Customers[0].Password);
        }

        [TestMethod]
        [ExpectedException(typeof(LoginException),
            "Invalid login!")]
        public void TestException()
        {
            Warehouse warehouse = new Warehouse();
            const int n = 7;
            for (int i = 0; i < n; i++)
                warehouse.RegistrationCustomer(new Customer() 
                { 
                    Login = $"Login", 
                    Password = "123", 
                    Adress = "pushkinskaya 22" 
                });
        }

        [TestMethod]
        public void TestAuthentication() 
        {
            Warehouse warehouse = new Warehouse();
            const int n = 2;
            for (int i = 0; i < n; i++)
            {
                warehouse.RegistrationCustomer(new Customer()
                {
                    Login = $"Customer{i}",
                    Password = "123",
                    Adress = "saltovskaya 33"
                });
            }
            Assert.IsTrue(warehouse.AuthenticationCustomer(new Customer()
            { 
                Login = "Customer0", 
                Password = "123" 
            }));
            Assert.IsTrue(warehouse.AuthenticationCustomer(new Customer() 
            { 
                Login = "Customer1",
                Password = "123" 
            }));
            Assert.IsFalse(warehouse.AuthenticationCustomer(new Customer() 
            { 
                Login = "Customer0",
                Password = "143" 
            }));
            Assert.IsFalse(warehouse.AuthenticationCustomer(new Customer() 
            { 
                Login = "Customer33",
                Password = "123" 
            }));
        }
    }

 }
