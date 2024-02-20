using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha1
{
    public class Pederas
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0) throw new Exception();
                else Console.WriteLine(Math.Sqrt(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("Nevalidno chislo");
            }
            catch (Exception)
            {
                Console.WriteLine("Nevalidno chislo");
            }
            finally { Console.WriteLine("Goodbye."); }
        }
    }
}
 