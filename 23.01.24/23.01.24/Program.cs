using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._24
{
    public class Car
    {
        protected string model;
        protected string engineType;
        protected int engineVolume;
        protected string sizeType;
        public string Model { set => this.model = value; get => this.model; }
        public string EngineType { set => this.engineType = value; get => this.engineType; }
        public string SizeType { set => this.sizeType = value; get => this.sizeType; }
        public int EngineVolume { set => this.engineVolume = value; get => this.engineVolume; }
        public Car(string m, string t, int v, string s)
        {
            this.model = m;
            this.engineType = t;
            this.engineVolume = v;
            this.sizeType = s;
        }
        public Car()
        {
            this.model = null;
            this.engineType = null;
            this.engineVolume = 0;
            this.sizeType = null;
        }
        public void Input()
        {
            Console.Write("Model: ");
            this.model = Console.ReadLine();
            Console.Write("Engine type: ");
            this.engineType = Console.ReadLine();
            Console.Write("Engine Volume: ");
            this.engineVolume = int.Parse(Console.ReadLine());
            Console.Write("Car size type: ");
            this.sizeType = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"Car: {this.model}________________");
            Console.WriteLine($"Engine type: {this.engineType}");
            Console.WriteLine($"Engine Volume: {this.engineVolume}");
            Console.WriteLine($"Car size type: {this.sizeType}");
            Console.WriteLine();
        }
    }
    public class Porsche : Car
    {
        public Porsche() : base() { }
        public Porsche(string m, string t, int v, string s) : base(m, t, v, s) { }
        public Porsche(Car car1)
        {
            base.model = car1.Model;
            base.engineType = car1.EngineType;
            base.engineVolume = car1.EngineVolume;
            base.sizeType = car1.SizeType;
        }
        public void Input()
        {
            base.model = Console.ReadLine();
            base.engineType = Console.ReadLine();
            base.engineVolume = int.Parse(Console.ReadLine());
            base.sizeType = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"Car: {base.model}________________");
            Console.WriteLine($"Engine type: {base.engineType}");
            Console.WriteLine($"Engine Volume: {base.engineVolume}");
            Console.WriteLine($"Car size type: {base.sizeType}");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Input();
            car1.Output();
            if (car1.Model == "Porsche")
            {
                Porsche p1 = new Porsche(car1);
                p1.Output();
            }
        }
    }
}
