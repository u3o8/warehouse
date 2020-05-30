using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseLibrary.Models;

namespace WarehouseTest
{
    [TestClass]
    public class GenerateEmpty
    {
        [TestMethod]
        public void GenerateData()
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Save();
        }
    }
}
