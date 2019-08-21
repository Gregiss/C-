using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arrayNomes = new String[10];
            for(int i = 0; i < arrayNomes.Length; i++)
            {
                Console.Write($"Informe o nome? {i + 1} : ");
                arrayNomes[i] = Console.ReadLine();
                Console.WriteLine("");
            }
            Array.Sort(arrayNomes, StringComparer.InvariantCultureIgnoreCase);
            Array.ForEach(arrayNomes, x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
