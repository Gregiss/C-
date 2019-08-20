using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(total += i);
                }
            }
            Console.ReadLine();
        }
    }
}
