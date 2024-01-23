using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._24_2_
{
    public class Shape
    {
        protected double width;
        protected double lenght;
        public double Width { set => this.width = value; get => this.width; }
        public double Lenght { set => this.lenght = value; get => this.lenght; }
        public Shape(double w, double l)
        {
            this.width = w;
            this.lenght = l;
        }
        public virtual double calculateArea()
        {
            return this.width * this.lenght;
        }
    }
    public class Rectangle: Shape
    {
        public Rectangle(double w, double l) : base(w, l) { }
        public override double calculateArea()
        {
            return base.width * base.lenght;
        }
    }
    public class Parallelepiped : Rectangle
    {
        private double height;
        public double Height { set => this.height = value; get => this.height; }
        public Parallelepiped(double w, double l, double h) : base(w, l)
        {
            this.height = h;
        }
        public override double calculateArea()
        {
            return 2 * (width * lenght + width*height + lenght * height);
        }
        public double calculateVolume()
        {
            return (width * lenght * height);
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double w, double l) : base(w, l) { }
        public override double calculateArea()
        {
            return (base.width * base.lenght) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lenght: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Shape s1 = new Shape(width, lenght);
            Console.WriteLine("Area shape: " + s1.calculateArea());
            Rectangle r1 = new Rectangle(width, lenght);
            Console.WriteLine("Area rectangle: " + r1.calculateArea());
            Triangle t1 = new Triangle(width, lenght);
            Console.WriteLine("Area triangle: " + t1.calculateArea());
            Parallelepiped p1 = new Parallelepiped(width, lenght, height);
            Console.WriteLine("Area paralelepiped: " + p1.calculateArea());
            Console.WriteLine("Volume paralelepiped: " + p1.calculateVolume());
        }
    }
}
