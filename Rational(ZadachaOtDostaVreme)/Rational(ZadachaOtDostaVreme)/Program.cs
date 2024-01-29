using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_ZadachaOtDostaVreme_
{
    public class Rational
    {
        int num;
        int denum;
        public int Num { set => this.num = value; get => this.num; }
        public int Denum { set => this.denum = value; get => this.denum; }
        public Rational(int x, int y)
        {
            this.num = x;
            this.denum = y;
        }
        public Rational(Rational r)
        {
            this.num = r.num;
            this.denum = r.denum;
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            Rational result = new Rational(0,1);
            result.denum = r1.denum * r2.denum;
            result.num = r1.num * r2.denum + r1.num * r2.denum;
            return result;
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            Rational result = new Rational(0,1);
            result.denum = r1.denum * r2.denum;
            result.num = r1.num * r2.denum - r1.num * r2.denum;
            return result;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            Rational result = new Rational(0, 1);
            result.denum = r1.denum * r2.denum;
            result.num = r1.num *  r2.num;
            return result;
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            Rational result = new Rational(0, 1);
            result.denum = r1.denum * r2.num;
            result.num = r1.num * r2.denum;
            return result;
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            if (r1.num * r2.denum > r2.num * r1.denum) return true;
            else return false;
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            if (r1.num * r2.denum < r2.num * r1.denum) return true;
            else return false;
        }
        public override string ToString()
        {
            return num.ToString() + "/" + denum.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purva drob: ");
            List<int> first = Console.ReadLine().Split('/').Select(int.Parse).ToList();
            Console.Write("Vtora drob: ");
            List<int> second = Console.ReadLine().Split('/').Select(int.Parse).ToList();
            Rational a = new Rational(first[0], first[1]);
            Rational b = new Rational(second[0],second[1]);
            Rational c = a + b; Console.WriteLine(c.ToString());
            Rational d = a - b; Console.WriteLine(d.ToString());
            Rational e = a * b; Console.WriteLine(e.ToString());
            Rational f = a / b; Console.WriteLine(f.ToString());
            if (a < b) Console.WriteLine("a < b");
            else if (a > b) Console.WriteLine("a > b");
            else Console.WriteLine("a = b");
        }
    }
}
