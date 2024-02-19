using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("string_text.txt");
            List<string> a = new List<string>();
            int br = 0;
            while (!r.EndOfStream)
            {
                a.Add(r.ReadLine());
            }
            r.Close();
            StreamWriter m = new StreamWriter("string_text.txt");
            for (int i = 0; i < a.Count(); i++)
            {
                a[i] = i + ": " + a[i];
                m.WriteLine(a[i]);
            }
            m.Close();
        }
    }
}
