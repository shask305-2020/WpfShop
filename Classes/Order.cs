using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineShop
{
    internal class Order
    {
        private static int _countOrder = 0;
        private int _orderId;
        private People _client;
        private List<Product> pr_list;
        private decimal _orderSum = 0;

        public People Client { get { return _client; } }
        public List<Product> PrList { get {  return pr_list; } }
        public decimal OrderSum { get { return _orderSum;} }

        public Order(People client)
        {
            _orderId = ++_countOrder;
            _client = client;
            pr_list = new List<Product>();
        }

        public void AddProduct(Product product, int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                pr_list.Add(product);
                _orderSum += product.Price;
            }
        }
        public void PrintOrder()
        {
            Console.WriteLine($"Номер заказа: {_orderId}");
            Console.WriteLine($"Клиент: {_client.Name}");
            Console.WriteLine("Номер\tНаименование\tЦена");

            int i = 1;
            string str = "";
            foreach (Product product in pr_list)
            {
                str = $"{i}\t{product.Name}\t\t{product.Price} руб.";
                Console.WriteLine(str);
                i++;
            }
            Console.WriteLine($"Сумма к оплате: {_orderSum} руб." + "\n");
        }
    }
}
