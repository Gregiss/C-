using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] notas = new String[10, 2];
            int media = 0, nomeIndice = 0;
            String aux = "";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Qual o nome do aluno {i + 1} :");
                notas[i, nomeIndice] = Console.ReadLine();
                aux = notas[i, 0];
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Qual a {j + 1} nota de {aux} : ");
                    notas[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                }
            }
            Console.ReadLine();
        }
    }
}
