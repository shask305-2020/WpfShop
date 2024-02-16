using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineShop
{
    internal class People
    {
        private static int _countClient = 0;
        private int _id;
        private string _name;
        private decimal _money = 0;

        public int Id { get { return _id; } }
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public decimal Money
        { 
            get { return _money; } 
            private set
            {
                if (value >= 0)
                    _money = value;
            }
        }
        public People(string name, decimal money = 0)
        {
            _id = ++_countClient;
            Name = name;
            Money = money;
        }
        public People()
        {
            _id = ++_countClient;
        }
        public bool AddMoney(decimal money)
        {
            if (money < 0)
                return false;
            if (money > 0)
            {
                Money = _money + money;
                return true;
            }
            else return false;
        }
        public bool RemoveMoney(decimal money)
        {
            if (money < 0)
                return false;
            if (money > 0 && _money >= money)
            {
                Money = _money - money;
                return true;
            }
            else return false;
        }
        public void PeopleInfo()
        {
            Console.WriteLine($"ID покупателя: {Id}");
            Console.WriteLine($"Имя покупателя: {Name}");
            Console.WriteLine($"Баланс покупателя: {Money}\n");
        }
        public override string ToString()
        {
            string info = $"{Name} ({Money} руб.)";
            return info;
        }
    }
}
