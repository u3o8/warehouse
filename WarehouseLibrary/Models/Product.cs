using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    // Товар – это наименование + идентификатор + ед.измерения + цена + количество + дата последнего завоза.
    //
    [Serializable]
    public class Product
    {
        public string Name { set; get; }

        // Артикул другими словами.
        public int Id { set; get; } 
        public string Unit { set; get; }
        public decimal Price { set; get; }
        public double Amount { set; get; }
        public DateTime DateTime { set; get; }

        // Перегрузим метод для сравнения продуктов. Считаем продукты эквивалентными, 
        // если имя + айди + ед. измерения + цена совпадают.
        // Количество не используется при сравнении на эквивалентность.
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Product other = (Product)obj;
            return (this.Name == other.Name) && (this.Id == other.Id) &&
                (this.Unit == other.Unit) && (this.Price == other.Price);
        }

        // Так как перегрузили Equals(Object obj), перегружаем GetHashCode().
        public override int GetHashCode()
        {
            return 1;
        }

        // Проверка наличия товара в определенной коллекции.
        public bool CheckProduct(List<Product> products)
        {
            foreach (Product temp in products)
            {
                if (this.Equals(temp))
                {
                    // Если уже имеем данный продукт на складе, 
                    // то просто меняем количество.
                    temp.Amount += this.Amount;

                    //И дату последнего завоза
                    temp.DateTime = this.DateTime;
                    // Указываем, что товар есть на складе,
                    // данный товар мы уже не будем добавлять.
                    return true;
                }
            }
            return false;
        }

    }
}
