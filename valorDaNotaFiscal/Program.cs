using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valorDaNotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, valorDaNotaFiscal = 0, imposto = 0;
            while (true)
            {
                Console.WriteLine("Informe um valor");
                valor = Convert.ToDouble(Console.ReadLine());
                if (valor < 999)
                {
                    imposto = 0.02;
                }
                else if (valor >= 1000 && valor <= 2999)
                {
                    imposto = 0.025;
                }
                else if (valor >= 3000 && valor <= 6999)
                {
                    imposto = 0.028;
                }
                else if (valor >= 7000)
                {
                    imposto = 0.03;
                }

                valorDaNotaFiscal = valor * imposto;
                Console.WriteLine("O imposto é de " + imposto + "\nValor com imposto é de " + valorDaNotaFiscal);
            }
            }
    }
}
