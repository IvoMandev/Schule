using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_abstractni_klasove_
{
    public abstract class Furniture
    {
        string typeProduct; public string TypeProduct { set => this.typeProduct = value; get => this.typeProduct; }
        double productionPrice; public double ProductionPrice { set => this.productionPrice = value; get => this.productionPrice; }
        public abstract double PriceClient();
        public Furniture(string t, double p)
        {
            this.typeProduct = t; this.productionPrice = p;
        }
    }
    public class Table : Furniture
    {
        public Table(string t, double p) : base(t, p) { }
        public override double PriceClient()
        {
            return base.ProductionPrice + base.ProductionPrice * 0.2;
        }
        public override string ToString()
        {
            return $"The table costs {PriceClient():f2} lv.”";
        }
    }
    public class Cabinet : Furniture
    {
        int numberOfHinges; public int NumberOfHinges { set => this.numberOfHinges = value; get => this.numberOfHinges; }
        public Cabinet(string t, double p, int n) : base(t, p) { this.numberOfHinges = n; }
        public override double PriceClient()
        {
            return base.ProductionPrice + base.ProductionPrice * 0.15 + this.numberOfHinges * 4.5;
        }
        public override string ToString()
        {
            return $"The cabinet costs {PriceClient():f2} lv.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string furniture = Console.ReadLine();
            List<string> a = new List<string>();
            List<Table> tables = new List<Table>();
            List<Cabinet> cabinets = new List<Cabinet>();
            while (furniture != "END")
            {
                a=furniture.Split(' ').ToList();
                if (a[0] == "table")
                {
                    Table t = new Table(a[0], double.Parse(a[1]));
                    tables.Add(t);
                }
                else if (a[0] == "cabinet")
                {
                    Cabinet c = new Cabinet(a[0], double.Parse(a[1]), int.Parse(a[2]));
                    cabinets.Add(c);
                }
                furniture = Console.ReadLine();
            }
            Console.WriteLine(tables.Count());
            Console.WriteLine("All tables: ");
            for (int i = 0; i < tables.Count(); i++)
            {
                Console.WriteLine(tables[i].ToString());
            }
            Console.WriteLine("All cabinets: ");
            for (int i = 0; i < cabinets.Count(); i++)
            {
                Console.WriteLine(cabinets[i].ToString());
            }
        }
    }
}
