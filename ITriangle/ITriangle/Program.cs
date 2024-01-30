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
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }
    public class ITriangle2: ITriangle
    {
        double a;
        double b;
        double alpha;
        public ITriangle2(double A, double B, double Alpha)
        {
            this.a = A;
            this.b = B;
            this.alpha = (Alpha * Math.PI) / 180;
        }
        double ITriangle.Face()
        {
            return (this.a * this.b * Math.Sin(alpha)) / 2;
        }
        double ITriangle.Perimeter()
        {
            double c = Math.Sqrt(this.a * this.a + this.b * this.b - 2 * this.a * this.b * Math.Cos(alpha));
            return this.a + this.b + c;
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            ITriangle a = new ITriangle2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"Perimeter: {a.Perimeter()}");
            Console.WriteLine($"Face: {a.Face()}");
        }
    }
}
