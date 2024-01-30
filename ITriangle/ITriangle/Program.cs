using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITriangle
{
    public interface ITriangle
    {
        double Perimeter();
        double Face();
    }
    public class ITriangle1 : ITriangle
    {
        double a;
        double b;
        double c;
        public ITriangle1(double a1, double b1, double c1)
        {
            this.a = a1;
            this.b = b1;
            this.c = c1;
        }
        double ITriangle.Perimeter()
        {
            return this.a + this.b + this.c;
        }
        double ITriangle.Face()
        {
            double p = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(p * (p-this.a) * (p - this.b) * (p-this.c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITriangle a = new ITriangle1(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"Perimeter: {a.Perimeter()}");
            Console.WriteLine($"Face: {a.Face()}");
        }
    }
}
