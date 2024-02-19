using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("string_text.txt");
            List<string> a = new List<string>();
            while (!r.EndOfStream)
            {
                a.Add(r.ReadLine());
            }
            
            for (int i = 1; i < a.Count(); i+=2)
            {
                Console.WriteLine(a[i]);
            }
            r.Close();
        }
    }
}
