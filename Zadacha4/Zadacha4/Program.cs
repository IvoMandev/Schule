using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader("string_text.txt");
            StreamReader b = new StreamReader("stringText.txt");
            List<string> a1 = new List<string>();
            List<string> b1 = new List<string>();
            while (!a.EndOfStream) a1.Add(a.ReadLine());
            while (!b.EndOfStream) b1.Add(b.ReadLine());
            int same = 0;
            int diff = 0;
            for (int i = 0; i < a1.Count(); i++)
            {
                if (a1[i] == b1[i]) same++;
                else diff++;
            }
            Console.WriteLine("Same lines: " + same);
            Console.WriteLine("Different lines: " + diff);
            a.Close();
            b.Close();
        }
    }
}
