using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete 10 chisla: ");
            List<int> a = new List<int>();
            for (int i = 1; i < 10; i++)
            { 
                try
                {
                    Console.Write($"Vavedete a{i}: ");
                    a.Add(int.Parse(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    Console.WriteLine("ÏNvalid format");
                }
                catch (Exception) { }
            }
        }
    }
}
