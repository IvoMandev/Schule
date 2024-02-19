using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("names.txt");
            List<string> a = new List<string>();
            while (!r.EndOfStream) a.Add(r.ReadLine());
            for (int i = 0; i < a.Count(); i++)
            {
                if (i % 2 != 0)
                {
                    a.Remove(a[i]);
                    i++;
                }
            }
            r.Close();
            StreamWriter m = new StreamWriter("new_file.txt");
            for (int i = 0; i < a.Count(); i++) m.WriteLine(a[i]);
            m.Close();
        }
    }
}
