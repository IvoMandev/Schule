using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugaZadacha
{
    public class Shape
    {
        int x; int y;
        public int X { set => this.x = value; get => this.x; }
        public int Y { set => this.y = value; get => this.y; }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a SHAPE at {0},{1}", this.x, this.y);
        }
        public Shape(int xa, int ya)
        {
            this.x = xa;
            this.y = ya;
        }
    }
    public class Circle: Shape
    {
        public Circle(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle at {0},{1}", base.X,base.Y) ;
        }
    }
    public class Square : Shape
    {
        public Square(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square at {0},{1}", base.X, base.Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Circle a = new Circle(x, y);
            Square b = new Square(x, y);
            Square c = new Square(x, y);
        }
    }
}
