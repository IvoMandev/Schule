using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    public class Human
    {
        int age;
        string firstName;
        string lastName;
        public int Age { set => this.age = value; get => this.age; }
        public string FirstName { set => this.firstName = value; get => this.firstName; }
        public string LastName { set => this.lastName = value; get => this.lastName; }
        public Human(string f, string l, int a)
        {
            this.age = a;
            this.firstName = f;
            this.lastName = l;
        }
        public override string ToString()
        {
            return firstName + " " + lastName + $" Age: {Age.ToString()} years old";
        }
    }
    public class Student : Human
    {
        double grade;
        public double Grade { set => this.grade = value; get => this.grade; }
        public Student(string f, string l, int a, double g) : base(f, l, a)
        {
            this.grade = g;
        }
        public override string ToString()
        {
            return base.FirstName + " " + base.LastName + $" Age: {Age.ToString()} years old" + $" Grade:  + {grade.ToString():2f}";
        }
    }
    public class Worker : Human
    {
        double wage;
        int workHours;
        public double Wage { set => this.wage = value; get => this.wage; }
        public int WorkHours { set => this.workHours = value; get => this.workHours; }
        public Worker(string f, string l, int a, double wa, int wo) : base(f, l, a)
        {
            this.wage = wa;
            this.workHours = wo;
        }
        public double Salary(double wage, double work)
        {
            double salary = wage * work;
            return salary;
        }
        public override string ToString()
        {

            return base.FirstName + " " + base.LastName + $" Age: {Age.ToString()} years old" + $" Salary:  + ${Salary(this.Wage, this.WorkHours).ToString():2f}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            List<Human> human = new List<Human>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Your choice[s - student], [w - worker]: ");
                string choice = Console.ReadLine();
                if (choice == "s")
                {
                    Console.Write("Grade: ");
                    double grade = double.Parse(Console.ReadLine());
                    Student s = new Student(firstName, lastName, age, grade);
                    human.Add(s);
                }
                else if (choice == "w")
                {
                    Console.Write("Wage: ");
                    double wage = double.Parse(Console.ReadLine());
                    Console.Write("Hours worked: ");
                    int hours = int.Parse(Console.ReadLine());
                    Worker w = new Worker(firstName, lastName, age, wage, hours);
                    human.Add(w);
                }
            }
            human.Reverse();
            for (int i = 0; i < human.Count(); i++)
            {
                Console.WriteLine(human[i].ToString());
            }
        }
    }
}
