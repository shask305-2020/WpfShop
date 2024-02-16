using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineShop
{
    internal class Program
    {
        private static List<People> peoples = new List<People>();
        private static List<Product> products = new List<Product>();

        static void NeMain(string[] args)
        {
            Test1();
            //Test2(peoples);
            Test3();
            //Test4(products);
            Test5();
            Test6();
            Console.ReadKey();
        }

        private static void Test1()
        {
            var ivan = new People();
            var igor = new People("Игорь");
            ivan.Name = "Иван";
            
            peoples.Add(ivan);
            peoples.Add(igor);
        }

        private static void Test2(List<People> peopleList)
        {
            foreach (var people in peopleList)
            {
                people.PeopleInfo();
            }
        }

        private static void Test3()
        {
            var tea = new Product("Липтон", 49);
            var milk = new Product("Молоко", 56);

            products.Add(tea);
            products.Add(milk);
        }

        private static void Test4(List<Product> productList)
        {
            foreach (var product in productList)
            {
                product.GetProductInfo();
            }
        }

        private static void Test5()
        {
            Order ord_1 = new Order(peoples[0]);
            ord_1.AddProduct(products[0], 3);
            ord_1.AddProduct(products[1], 2);
            ord_1.PrintOrder();
        }
        private static void Test6()
        {
            Order ord_1 = new Order(peoples[1]);
            ord_1.AddProduct(products[0]);
            ord_1.AddProduct(products[1]);
            ord_1.PrintOrder();
        }
    }
}
