using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 3, b = 4, a = 5;
            b = Math.Pow(b, 2);
            c = Math.Pow(c, 2);
            double hipotenusa = b + c;
            hipotenusa = Math.Sqrt(hipotenusa);
            Console.WriteLine(hipotenusa);
            Console.ReadLine();
        }
    }
}
