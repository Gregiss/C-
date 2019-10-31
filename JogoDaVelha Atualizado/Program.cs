using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabuleiro = new int[3, 3];
            int whereX = 0;
            int whereY = 0;
            String keyPress = "";
            int selectX = 0;
            int selectY = 0;
            int vez = 0;
            String vezS = "";
            int jogadas = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = -1;
                }
            }
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[i, j] == -1)
                        {
                            if (whereX == j && whereY == i)
                            {
                                Console.Write(" = ");
                            }
                            else
                            {
                                Console.Write(" - ");
                            }  
                        } else if(tabuleiro[i, j] == 0)
                        {
                            Console.Write(" O ");
                        }
                        else if (tabuleiro[i, j] == 1)
                        {
                            Console.Write(" X ");
                        }
                        if (j == 2 || j == 4)
                        {
                            Console.WriteLine("");
                        }
                    }
                }
                if (vez == 0)
                {
                    vezS = "O";
                }
                else
                {
                    vezS = "X";
                }
                Console.WriteLine($"\n Vez de { vezS }");
                keyPress = ""+Console.ReadKey(true).Key;
                if (keyPress.Equals("RightArrow"))
                {
                   if(whereX < 2)
                    {
                        whereX++;
                    }
                }
                else if (keyPress.Equals("LeftArrow"))
                {
                    if (whereX > 0)
                    {
                        whereX--;
                    }
                }
                else if (keyPress.Equals("UpArrow"))
                {
                    if (whereY > 0)
                    {
                        whereY--;
                    }
                }
                else if (keyPress.Equals("DownArrow"))
                {
                    if (whereY < 2)
                    {
                        whereY++;
                    }
                }
                else if (keyPress.Equals("Enter"))
                {
                    selectX = whereX;
                    selectY = whereY;
                    if(vez == 0)
                    {
                        vez = 1;
                    }
                    else
                    {
                        vez = 0;
                    }
                    if(tabuleiro[selectY, selectX] == 0 || tabuleiro[selectY, selectX] == 1)
                    {

                    }
                    else
                    {
                        tabuleiro[selectY, selectX] = vez;
                        jogadas++;
                    }
                    
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[0, 0] == 0 && tabuleiro[0, 1] == 0 && tabuleiro[0, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[1, 0] == 0 && tabuleiro[1, 1] == 0 && tabuleiro[1, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[2, 0] == 0 && tabuleiro[2, 1] == 0 && tabuleiro[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 0] == 0 && tabuleiro[1, 0] == 0 && tabuleiro[2, 0] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 0] == 0 && tabuleiro[1, 1] == 0 && tabuleiro[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 0] == 1 && tabuleiro[1, 1] == 1 && tabuleiro[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 1] == 0 && tabuleiro[1, 1] == 0 && tabuleiro[2, 1] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 2] == 0 && tabuleiro[1, 2] == 0 && tabuleiro[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 1] == 0 && tabuleiro[1, 1] == 0 && tabuleiro[2, 2] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 2] == 0 && tabuleiro[0, 1] == 0 && tabuleiro[2, 0] == 0)
                        {
                            Console.WriteLine("O ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        if (tabuleiro[0, 0] == 1 && tabuleiro[0, 1] == 1 && tabuleiro[0, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[1, 0] == 1 && tabuleiro[1, 1] == 1 && tabuleiro[1, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[2, 0] == 1 && tabuleiro[2, 1] == 1 && tabuleiro[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                        else if (tabuleiro[0, 0] == 1 && tabuleiro[1, 0] == 1 && tabuleiro[2, 0] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 1] == 1 && tabuleiro[1, 1] == 1 && tabuleiro[2, 1] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 2] == 1 && tabuleiro[1, 2] == 1 && tabuleiro[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 1] == 1 && tabuleiro[1, 1] == 1 && tabuleiro[2, 2] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        else if (tabuleiro[0, 2] == 1 && tabuleiro[0, 1] == 1 && tabuleiro[2, 0] == 1)
                        {
                            Console.WriteLine("X ganhou");
                            Console.WriteLine("Clique enter para jogar novamante");
                            for (int b = 0; b < 3; b++)
                            {
                                for (int h = 0; h < 3; h++)
                                {
                                    tabuleiro[b, h] = -1;
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
                        if (jogadas == 9)
                        {
                            Console.WriteLine("Deu velha");
                            Console.WriteLine("Clique enter para jogar novamante");
                        }
                    }
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
