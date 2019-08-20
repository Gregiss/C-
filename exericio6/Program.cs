using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0, total = 1;
            for(int i = 0; i <= 10; i++)
            {
                aux = i;
                total = i * i - aux;
                if(total < 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(total);
                }
            }
            Console.ReadLine();
        }
    }
}
