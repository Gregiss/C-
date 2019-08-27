using bancoa.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Cliente objCliente = new Cliente();
                Console.WriteLine("Qual o nome do cliente?");
                objCliente.setNome(Console.ReadLine());
                Console.WriteLine($"Qual o ano que nasceu { objCliente.getNome() } ?");
                objCliente.setDataNasc(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Qual o CPF de { objCliente.getNome() } ?");
                objCliente.setCpf(Console.ReadLine());
                Console.WriteLine($"Qual o RG de { objCliente.getNome() } ?");
                objCliente.setRg(Console.ReadLine());
                objCliente.setCode(i);
                Console.WriteLine(objCliente.getCode() + ": " + objCliente.getNome() + " nasceu em " + objCliente.getDataNasc() + ", tem " + objCliente.getIdade() + " anos \nCPF: " + objCliente.getCpf() + "\nRG: " + objCliente.getRg());
            }
            for (int i = 0; i < 8; i++)
            {
                cardCredit newCard = new cardCredit();
                Console.WriteLine("Qual o numero do cartão?");
                newCard.setNumero(Console.ReadLine());
                Console.WriteLine("Qual a validade do cartão?");
                newCard.setValidade(Console.ReadLine());
                Console.WriteLine("Qual o Código de Segurança do cartão?");
                newCard.setCvv(Console.ReadLine());
                Console.WriteLine(newCard.getNumero() + ":" + newCard.getValidade() + ":" + newCard.getCvv());
            }

            for (int i = 0; i < 5; i++)
            {
                Agencia age = new Agencia();
                Console.WriteLine("Qual o agencia?");
                age.setAgencia(Console.ReadLine());
                Console.WriteLine(age.getAgencia());
            }

            Console.ReadLine();
        }
    }
}
