using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    //класс книги
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
