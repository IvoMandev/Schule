using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("names.txt");
            StreamReader r1 = new StreamReader("text.txt");
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            while (!r.EndOfStream) a.Add(r.ReadLine());
            while (!r1.EndOfStream)
            {
                b = r1.ReadToEnd().Split(' ').ToList();
            }
            for (int i = 0; i < a.Count(); i++)
            {
                if (b.Contains(a[i]))
                {
                    while (b.Contains(a[i])) b.Remove(a[i]);
                }
            }
            r.Close();
            StreamWriter m = new StreamWriter("new_file.txt");
            for (int i = 0; i < b.Count(); i++) m.Write(b[i] + " ");
            m.Close();
        }
    }
}
