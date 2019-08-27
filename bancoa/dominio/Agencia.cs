using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoa.dominio
{
    class Agencia
    {
        String agencia;
        public void setAgencia(String agencia)
        {
            string texto = agencia;
            int count = 0;
            Boolean error = true;
            while (error)
            {
                foreach (char c in agencia)
                {
                    count++;
                }
                if (count < 4)
                {
                    error = true;
                }
                else
                {
                    this.agencia = agencia;
                    error = false;
                }
                if (error)
                {
                    count = 0;
                    Console.WriteLine("Agencia invalida");
                    Console.WriteLine("Insira outro por favor");
                    agencia = Console.ReadLine();
                }
            }
        }

        public String getAgencia()
        {
            return this.agencia;
        }

    }
}
