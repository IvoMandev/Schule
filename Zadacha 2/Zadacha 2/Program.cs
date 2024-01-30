using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    public interface IContainer
    {
        int GetContainerID();
        int GetContainerWeight();
        void setContainerID(int id);
        void setContainerWeight(int weight);
    }
    public class ExplicitContainer : IContainer
    {
        private int id;
        private int weight = 20000;
        int IContainer.GetContainerID() { return id; }
        int IContainer.GetContainerWeight() { return weight; }
        void IContainer.setContainerID(int id) { this.id = id; }
        void IContainer.setContainerWeight(int weight) { this.weight = weight; }
    }
    public class ImplicitContainer : IContainer
    {
        private int id;
        private int weight;
        public int GetContainerID() { return id; }
        public int GetContainerWeight() { return weight; }
        public void setContainerID(int id) { this.id = id; }
        public void setContainerWeight(int weight) { this.weight = weight; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IContainer c1 = new ExplicitContainer();
            ImplicitContainer c2 = new ImplicitContainer();
            IContainer c3 = new ImplicitContainer();
            c1.setContainerID(1001);
            c2.setContainerID(1002);
            c3.setContainerID(1003);
            Console.WriteLine($"ID: {c1.GetContainerID()}");
            Console.WriteLine($"ID: {c2.GetContainerID()}");
            Console.WriteLine($"ID: {c3.GetContainerID()}");
        }
    }
}
