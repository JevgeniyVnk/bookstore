using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace bookstore
{
    //класс книги
    [XmlRoot("Book")]
    public class Book
    {
        [XmlAttribute("name")]
        public string Name { get; set; } = "";
        [XmlAttribute("price")]
        public double Price { get; set; } = 0;
        [XmlAttribute("author")]
        public string Author { get; set; } = "";
        public string ImgPath { get; set; } = "";
        [XmlAttribute("count")]
        public int Count { get; set; } = 0;
        [XmlAttribute("describtion")]
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
