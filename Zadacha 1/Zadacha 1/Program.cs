using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    abstract public class Shape
    {
        private int a;
        private int b;
        public int A { set => this.a = value; get => this.a; }
        public int B { set => this.b = value; get => this.b; }
        public abstract void Input();
        public abstract void Output(Rectangle r);
        public abstract double Area(Rectangle r);
        public Shape(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Shape()
        {
            this.a = 0;
            this.b = 0;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(int a, int b) : base(a, b) { }
        public Rectangle() : base() { }
        public override double Area(Rectangle r)
        {
            return r.A * r.B;
        }
        public override void Input()
        {
            Console.Write("A: ");
            base.A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            base.B = int.Parse(Console.ReadLine());
        }
        public override void Output(Rectangle r)
        {
            Console.WriteLine($"Rectangle: a = {r.A} b = {r.B}");
            Console.WriteLine($"Area: {r.Area(r)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Input();
            r1.Area(r1);
            r1.Output(r1);
        }
    }
}
