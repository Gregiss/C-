using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disiveis
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, valor2 = 0;
            for(int i = 0; i < 30; i++)
            {
                if(valor % 3 == 0)
                {
                    Console.WriteLine("O valor " + valor + " é divisivel por 3");
                }
                if (valor % 4 == 0)
                {
                    Console.WriteLine("O valor " + valor + " é divisivel por 4");
                }
                valor++;
            }
            Console.ReadLine();
        }
    }
}
