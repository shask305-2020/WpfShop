using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleOnlineShop
{
    internal class Product
    {
        private static int _countProduct = 0;
        private int _id;
        private string _name;
        private decimal _price;

        public int Id { get { return _id; } }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            private set
            {
                if (value > 0)
                    _price = value;
            }
        }
        //Конструкторы
        public Product(string name, decimal price)
        {
            _id = ++_countProduct;
            Name = name;
            Price = price;
        }
        

        public void GetProductInfo()
        {
            Console.WriteLine($"ID товара: {Id}");
            Console.WriteLine($"Название товара: {Name}");
            Console.WriteLine($"Цена: {Price}\n");
        }
        public override string ToString()
        {
            string info = $"{Name} ({Price} руб.)";
            return info;
        }
    }
}
