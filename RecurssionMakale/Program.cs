using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssionMakale
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion recursion = new Recursion();
            foreach (var tas in recursion.SirasizTaslar.Where(t => string.IsNullOrEmpty(t.UstNumara)))
            {
                recursion.TasYaz(tas);
            }

            Console.ReadLine();
        }
    }
}
