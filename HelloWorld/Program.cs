using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 0;
            int operation = 0;
            bool error = false;
            String hash;
            Console.WriteLine("Olá ao iBank\n Seu saldo atual é de "+saldo);
            while (true)
            {
                Console.WriteLine("\n Escreva as operações que queres\n 1-Depositar\n 2-Retirar saldo");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 1)
                {
                    Console.WriteLine("Qual o valor que queres depositar em sua conta?");
                    int newSaldo = Convert.ToInt32(Console.ReadLine());
                    saldo += newSaldo;
                    Console.WriteLine("Seu saldo atual é de " + saldo);
                    operation = 0;
                } else if(operation == 2)
                {
                    Console.WriteLine("Qual o valor que queres retirar em sua conta?");
                    error = true;
                    while (error)
                    {
                        int newSaldo = Convert.ToInt32(Console.ReadLine());
                        if (saldo < newSaldo)
                        {
                            Console.WriteLine("Não podes retirar um valor que não tenhas");
                        }
                        else
                        {
                            saldo -= newSaldo;
                            error = false;
                            Console.WriteLine("Seu saldo atual é de " + saldo);
                        }
                    }
                }
            }
        }

    }
}
