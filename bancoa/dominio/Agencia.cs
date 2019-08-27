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
        String conta;
        String numero;
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

        public void setConta(String conta)
        {
            this.conta = conta;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public String getAgencia()
        {
            return this.agencia;
        }

        public String getNumero()
        {
            return this.numero;
        }

        public String getConta()
        {
            return this.conta;
        }

    }
}
