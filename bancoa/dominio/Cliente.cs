using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoa.dominio
{
    class Cliente
    {
        String nome;
        int code;
        String rg, cpf;
        int dataNascimento;
        int idade;

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCode(int code)
        {
            this.code = code;
        }

        public void setRg(String rg)
        {
            string texto = rg;
            int count = 0;
            Boolean error = true;
            while (error)
            {
                foreach (char c in rg)
                {
                    count++;
                }
                if (count < 9)
                {
                    error = true;
                }
                else
                {
                    this.rg = rg;
                    error = false;
                }
                if (error)
                {
                    count = 0;
                    Console.WriteLine("RG invalido");
                    Console.WriteLine("Insira outro por favor");
                    rg = Console.ReadLine();
                }
            }
        }

        public void setDataNasc(int data)
        {
            Boolean error = true;
            while (error)
            {
                if (data >= 1200 && data <= 1903)
                {
                    error = true;
                }
                else
                {
                    if(data < 1904)
                    {
                        error = true;
                    }
                    else
                    {
                        error = false;
                    }
                }
                if (error)
                {
                    error = true;
                    Console.WriteLine("Data de nascimento invalido");
                    Console.WriteLine("Insira outro por favor");
                    data = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    this.dataNascimento = data;
                    this.idade = 2019 - data;
                }
            }
 
        }

        public void setCpf(String cpf)
        {
            string texto = cpf;
            int count = 0;
            Boolean error = true;
            while (error)
            {
                foreach (char c in cpf)
                {
                    count++;
                }
                if (count < 11)
                {
                    error = true;
                }
                else
                {
                    this.cpf = cpf;
                    error = false;
                }
                if (error)
                {
                    count = 0;
                    Console.WriteLine("CPF invalido");
                    Console.WriteLine("Insira outro por favor");
                    cpf = Console.ReadLine();
                }
            }
        }

        public int getDataNasc()
        {
            return this.dataNascimento;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getRg()
        {
            return this.rg;
        }

        public String getCpf()
        {
            return this.cpf;
        }

        public int getCode()
        {
            return this.code;
        }
    }
}
