using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Product
    {
        public int Id { get; }
        private static int _id;
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public int Count { get; set; }

        public Product()
        {
            _id++;
            Id = _id;
            this.Name = Name;
            this.Price = Price;
            this.StockCount = StockCount;
            this.Count = Count;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nPrice:{Price}\nStockCount:{StockCount}\nCount{Count}");
        }
    }
}
