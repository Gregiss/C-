using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoa.dominio
{
    class cardCredit
    {
        string numero;
        string validade;
        string cvv;

        public string getNumero()
        {
            return this.numero;
        }

        public String getValidade()
        {
            return this.validade;
        }

        public String getCvv()
        {
            return this.cvv;
        }

        public void setNumero(string numero)
        {
            string texto = numero;
            int count = 0;
            Boolean error = true;
            while (error)
            {
                foreach (char c in numero)
                {
                    count++;
                }
                if (count < 16)
                {
                    error = true;
                }
                else
                {
                    this.numero = numero;
                    error = false;
                }
                if (error)
                {
                    count = 0;
                    Console.WriteLine("Número de cartão invalido");
                    Console.WriteLine("Insira outro por favor");
                    numero = Console.ReadLine();
                }
            }
        }

        public void setCvv(string cvv)
        {
            string texto = cvv;
            int count = 0;
            Boolean error = true;
            while (error)
            {
                foreach (char c in cvv)
                {
                    count++;
                }
                if (count < 4)
                {
                    error = true;
                }
                else
                {
                    this.cvv = cvv;
                    error = false;
                }
                if (error)
                {
                    count = 0;
                    Console.WriteLine("Número de Código de Segurança invalido");
                    Console.WriteLine("Insira outro por favor");
                    cvv = Console.ReadLine();
                }
            }
        }

        public void setValidade(String validade)
        {
            this.validade = validade;
        }
    }
}
