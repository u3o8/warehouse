﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using WarehouseLibrary.Models;

namespace WarehouseLibrary.DAL
{
    class Dao
    {
        Warehouse warehouse;
        private Stream stream;
        const string filePath = "warehouse.bin";

        public Dao(Warehouse warehouse) {
            this.warehouse = warehouse;
        }

        public void Save() {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, warehouse);
            }
        }

        public void Load() {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Warehouse wr = (Warehouse)serializer.Deserialize(stream);

                //шото типа глубокого копирования
                Copy(wr.Products, warehouse.Products);
                Copy(wr.Customers, warehouse.Customers);
                Copy(wr.Orders, warehouse.Orders);
                Copy(wr.Sales_Invoices, warehouse.Sales_Invoices);
                Copy(wr.Purchase_Invoices, warehouse.Purchase_Invoices);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }


    }
}
