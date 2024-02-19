using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("string_text.txt");
            StreamReader b = new StreamReader("oneLine.txt");
            StreamWriter a = new StreamWriter("new_file.txt");
            a.Write(r.ReadToEnd() + b.ReadToEnd());
            r.Close();
            b.Close();
            a.Close();
        }
    }
}
