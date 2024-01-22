using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._01._24
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private string discount;
        private double price;
        private int pubDate;
        public string Title { set => this.title = value; get => this.title; }
        public string Author { set => this.author = value; get => this.author; }
        public string Publisher { set => this.publisher = value; get => this.publisher; }
        public string Discount { set => this.discount = value; get => this.discount; }
        public double Price { set => this.price = value; get => this.price; }
        public int PubDate { set => this.pubDate = value; get => this.pubDate; }
        public Book(string t, string a, int pub, double pr)
        {
            this.author = a;
            this.title = t;
            this.pubDate = pub;
            this.price = pr;
            this.publisher = "Unknown";
            this.discount = "Unavailable";
        }
        public Book(string t, string a, int pub, double pr, string p, string d)
        {
            this.author = a;
            this.title = t;
            this.publisher = p;
            this.discount = d;
            this.price = pr;
            this.pubDate = pub;
        }
        public Book(string t, string a, int pub, double pr, string p)
        {
            this.author = a;
            this.title = t;
            this.price = pr;
            this.pubDate = pub;
            this.publisher = p;
            this.discount = "Unavailable";

        }
        public void Print()
        {
            Console.WriteLine($"Book_______________");
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Publication date: {this.pubDate}");
            Console.WriteLine($"Price: {this.price}");
            Console.WriteLine($"Publisher: {this.publisher}");
            Console.WriteLine($"Discount: {this.discount}%");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book:");
            string book = Console.ReadLine();
            List<Book> books = new List<Book>();
            while (book != "End")
            {
                List<string> list = book.Split(',').ToList();
                if (list.Count == 6)
                {
                    Book a = new Book(list[0], list[1], int.Parse(list[2]), double.Parse(list[3]), list[4], list[5]);
                    books.Add(a);
                }
                else if (list.Count == 5)
                {
                    Book a = new Book(list[0], list[1], int.Parse(list[2]), double.Parse(list[3]), list[4]);
                    books.Add(a);
                }
                else if (list.Count == 4)
                {
                    Book a = new Book(list[0], list[1], int.Parse(list[2]), double.Parse(list[3]));
                    books.Add(a);
                }
                book = Console.ReadLine();
            }
            double sum = 0;
            books = books.OrderBy(a => a.Author).ToList();
            for (int i = 0; i < books.Count; i++)
            {
                books[i].Print();
                sum += books[i].Price;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
