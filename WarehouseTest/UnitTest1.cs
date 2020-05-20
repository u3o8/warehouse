using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLibrary.Models;

namespace WarehouseTest
{
    [TestClass]
    public class UnitTest1
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
            warehouse.Supply(new Purchase_Invoice() {
                Portions = test_portions,
                DateTime = DateTime.Now
            });
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
    }
}
