using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int vez = -1;
            bool comecou = true;
            int[,] matriz = new int[3, 3];
            bool dont = false;
            int jogadas = 0;

            //Prenche a matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = -1;
                }
            }

            String quem = "0";
            //Cria a matriz
            for (int i = 0; i < 9; i++)
            {
                if (i == 2)
                {
                    Console.Write(" - \n");
                }
                else if (i == 5)
                {
                    Console.Write(" - \n");
                }
                else
                {
                    Console.Write(" - ");
                }
            }
            while (comecou)
            {
                Console.WriteLine("\nEscreva qual posicao X queres jogar");
                int novaJogadaX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escreva qual posicao Y queres jogar");
                int novaJogadaY = Convert.ToInt32(Console.ReadLine());
                if (novaJogadaX > 3)
                {
                    dont = true;
                    Console.WriteLine("Não podes jogar neste lugar, erro interno");
                }
                else if (novaJogadaY > 3)
                {
                    dont = true;
                    Console.WriteLine("Não podes jogar neste lugar, erro interno");
                }
                else if (novaJogadaX < 0)
                {
                    dont = true;
                    Console.WriteLine("Não podes jogar neste lugar, erro interno");
                }
                else if (novaJogadaY < 0)
                {
                    dont = true;
                    Console.WriteLine("Não podes jogar neste lugar, erro interno");
                }
                else
                {
                    dont = false;
                }

                while (dont)
                {
                    Console.WriteLine("\nEscreva qual posicao X queres jogar");
                    novaJogadaX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva qual posicao Y queres jogar");
                    novaJogadaY = Convert.ToInt32(Console.ReadLine());
                    if (novaJogadaX > 3)
                    {
                        dont = true;
                        Console.WriteLine("Não podes jogar neste lugar, erro interno");
                    }
                    else if (novaJogadaY > 3)
                    {
                        dont = true;
                        Console.WriteLine("Não podes jogar neste lugar, erro interno");
                    }
                    else if (novaJogadaX < 0)
                    {
                        dont = true;
                        Console.WriteLine("Não podes jogar neste lugar, erro interno");
                    }
                    else if (novaJogadaY < 0)
                    {
                        dont = true;
                        Console.WriteLine("Não podes jogar neste lugar, erro interno");
                    }
                    else
                    {
                        dont = false;
                    }
                }
                   
                if (vez == 0)
                {
                    vez = 1;
                }
                else
                {
                    vez = 0;
                }
                if(matriz[novaJogadaX, novaJogadaY] == 0)
                {
                    Console.WriteLine("Não podes jogar aqui");
                    dont = true;
                }
                else if (matriz[novaJogadaX, novaJogadaY] == 1)
                {
                    Console.WriteLine("Não podes jogar aqui");
                    dont = true;
                }
                else
                {
                    jogadas++;
                    dont = false;
                }
                while (dont)
                {
                    Console.WriteLine("\nEscreva qual posicao X queres jogar");
                    novaJogadaX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escreva qual posicao Y queres jogar");
                    novaJogadaY = Convert.ToInt32(Console.ReadLine());
                    if (matriz[novaJogadaX, novaJogadaY] == 0)
                    {
                        Console.WriteLine("Não podes jogar aqui");
                        dont = true;
                    }
                    else if (matriz[novaJogadaX, novaJogadaY] == 1)
                    {
                        Console.WriteLine("Não podes jogar aqui");
                        dont = true;
                    }
                    else
                    {
                        dont = false;
                    }
                }
                matriz[novaJogadaX, novaJogadaY] = vez;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[i, j] == 0)
                        {
                            quem = "O";
                        }
                        else if (matriz[i, j] == 1)
                        {
                            quem = "X";
                        }
                        else
                        {
                            quem = "  -  ";
                        }
                        if (j == 2)
                        {
                            Console.Write("            " + quem + "     " + "\n");
                        }
                        else if (i == 3)
                        {
                            Console.Write("            " + quem + "     " + "\n");
                        }
                        else
                        {
                            Console.Write("            " + quem + "     ");
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[0, 0] == 0 && matriz[0, 1] == 0 && matriz[0, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[1, 0] == 0 && matriz[1, 1] == 0 && matriz[1, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[2, 0] == 0 && matriz[2, 1] == 0 && matriz[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 0] == 0 && matriz[1, 0] == 0 && matriz[2, 0] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 0] == 0 && matriz[1, 1] == 0 && matriz[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 0] == 1 && matriz[1, 1] == 1 && matriz[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 1] == 0 && matriz[1, 1] == 0 && matriz[2, 1] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 2] == 0 && matriz[1, 2] == 0 && matriz[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 1] == 0 && matriz[1, 1] == 0 && matriz[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 2] == 0 && matriz[0, 1] == 0 && matriz[2, 0] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        //verifica x
                        if (matriz[0, 0] == 1 && matriz[0, 1] == 1 && matriz[0, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[1, 0] == 1 && matriz[1, 1] == 1 && matriz[1, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[2, 0] == 1 && matriz[2, 1] == 1 && matriz[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                        else if (matriz[0, 0] == 1 && matriz[1, 0] == 1 && matriz[2, 0] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 1] == 1 && matriz[1, 1] == 1 && matriz[2, 1] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 2] == 1 && matriz[1, 2] == 1 && matriz[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 1] == 1 && matriz[1, 1] == 1 && matriz[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        else if (matriz[0, 2] == 1 && matriz[0, 1] == 1 && matriz[2, 0] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;
                        }
                        if(jogadas == 9)
                        {
                            Console.WriteLine("Deu velha");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    matriz[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            for (int t = 0; t < 9; t++)
                            {
                                if (t == 2)
                                {
                                    Console.Write(" - \n");
                                }
                                else if (t == 5)
                                {
                                    Console.Write(" - \n");
                                }
                                else
                                {
                                    Console.Write(" - ");
                                }
                            }
                            break;

                        }
                    }
                }
            }
            }
    }

}


