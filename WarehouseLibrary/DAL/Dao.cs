using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using WarehouseLibrary.Models;

namespace WarehouseLibrary.DAL
{
    // Класс для доступа к данным.
    //
    class Dao
    {
        Warehouse warehouse;
        private Stream stream;

        // Путь к файлу.
        const string filePath = "warehouse.bin";

        // Конструктор.
        public Dao(Warehouse warehouse) 
        {
            this.warehouse = warehouse;
        }

        // Метод для сохранения данных.
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, warehouse);
            }
        }

        // Метод для загрузки данных.
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Warehouse wr = (Warehouse)serializer.Deserialize(stream);

                // Глубокое копирование
                Copy(wr.Products, warehouse.Products);
                Copy(wr.Customers, warehouse.Customers);
                Copy(wr.Orders, warehouse.Orders);
                Copy(wr.SalesInvoices, warehouse.SalesInvoices);
                Copy(wr.PurchaseInvoices, warehouse.PurchaseInvoices);
                warehouse.Admin.Copy(wr.Admin);
            }

            // Метод для глубокого копирования.
            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }

    }
}
