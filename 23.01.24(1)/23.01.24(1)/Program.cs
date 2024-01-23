using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._24_1_
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            a.Bark();
            a.Eat();
            Cat b = new Cat();
            b.Eat();
            b.Meow();
            Puppy p = new Puppy();
            p.Eat();
            p.Bark();
            p.Weep();
        }
    }
}
