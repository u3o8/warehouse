using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    [Serializable]
    public class Product
    {
        public string Name { set; get; }
        public int Id { set; get; } //Артикул другими словами
        public string Unit { set; get; }
        public decimal Price { set; get; }
        public double Amount { set; get; }

        //Перегрузим метод для сравнения продуктов, считаем продукты эквивалентными, если
        // имя + айди + ед. измерения + цена совпадают
        // количество не используется при сравнении на эквивалентность
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            Product other = (Product)obj;
            return (this.Name == other.Name) && (this.Id == other.Id) &&
                (this.Unit == other.Unit) && (this.Price == other.Price);
        }
        public override int GetHashCode()
        {
            return 1;
        }

    }
}
