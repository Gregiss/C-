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
                    imposto = 2;
                }
                else if (valor >= 1000 && valor <= 2999)
                {
                    imposto = 2.5;
                }
                else if (valor >= 3000 && valor <= 6999)
                {
                    imposto = 2.8;
                }
                else if (valor >= 7000)
                {
                    imposto = 3;
                }

                valorDaNotaFiscal = valor * (imposto / 100);
                Console.WriteLine("A taxa é de " + imposto * 100 +"%\n"+"Valor do imposto é de " + valorDaNotaFiscal);
            }
            }
    }
}
