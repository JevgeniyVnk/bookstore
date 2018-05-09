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
        public string Name { get; set; } = "";
        public double Price { get; set; } = 0;
        public string Author { get; set; } = "";
        public string ImgPath { get; set; } = "";
        public int Count { get; set; } = 0;
        public string Describtion { get; set; } = "";
        public Book(string name, int count, double price, string author, string describtion)
        {
            Name = name;
            Price = price;
            Author = author;
            Count = count;
            Describtion = describtion;
        }
    }
}
