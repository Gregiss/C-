using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] notas = new String[10, 2];
            double[] mediaAluno = new double[10];
            String[] auxNome = new String[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Qual o nome do aluno {i + 1} :");
                notas[i, 0] = Console.ReadLine();
                auxNome[i] = notas[i, 0];
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Qual a {j + 1} nota de {auxNome[i]} : ");
                    notas[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mediaAluno[i] = ( Convert.ToDouble(notas[i, j]) + Convert.ToDouble(notas[i, j]) ) / 2;
                    if(j >= 1)
                    {
                        Console.WriteLine($"{auxNome[i]} media {mediaAluno[i] }");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
