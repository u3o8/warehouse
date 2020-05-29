using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLibrary.Models;

namespace WarehouseTest
{
    [TestClass]
    public class GenerateData
    {
        [TestMethod]
        public void TestMethod1()
        {
            Warehouse warehouse = new Warehouse();
            const int n = 100;
            const int m = 7;
            const int k = 4;

            // Products + PurchaseInvoices
            List<Portion> testPortions = new List<Portion>();
            for (int i = 0; i < n; i++)
            {
                // Cоздаю продукт, который является частью класса порция.
                Product newProduct = new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = (i + 1) * (1/5 + 10),
                    Unit = "kg",
                    DateTime = DateTime.Now + TimeSpan.FromDays(i)
                };

                // После этого создаю саму порцию.
                testPortions.Add(new Portion()
                {
                    Product = newProduct,
                    Amount = (i + 3) * 13
                });
            }
            warehouse.AcountingSupply(new PurchaseInvoice(testPortions));

            // Customers.
            for (int i = 0; i < m; i++)
            {
                warehouse.RegistrationCustomer(new Customer()
                {
                    Login = $"Customer{i}",
                    Password = "123456" + i,
                    Adress = "naukova " + (i + 3) * 7
                });
            }


            // Orders.
            for (int i = 0; i < k; ++i)
            {
                warehouse.AuthenticationCustomer(warehouse.Customers[i]);
                for (int g = 0; g < k; ++g)
                {
                    for (int j = i + 12; j < i + 16; ++j)
                    {
                        warehouse.AddBasket(warehouse.Products[j + g], 9 * (i + 3 + g));
                    }
                    warehouse.CreateNewOrder();
                }
                
            }

            // SalesInvoices + History for Сustomer.
            warehouse.СonfirmationOfOrder(warehouse.Orders[0]);
            warehouse.СonfirmationOfOrder(warehouse.Orders[2]);
            warehouse.СonfirmationOfOrder(warehouse.Orders[5]);
            warehouse.Save();

        }
    }
}
