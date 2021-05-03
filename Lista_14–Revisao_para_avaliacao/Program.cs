using System;

namespace Lista_14_Revisao_para_avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;
            bool continua = true;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| OPÇÃO    | EXERCÍCIOS");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F1       | EXERCÍCIOS 1");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F2       | EXERCÍCIOS 2");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F3       | EXERCÍCIOS 3");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F4       | EXERCÍCIOS 4");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F5       | EXERCÍCIOS 5");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F6       | EXERCÍCIOS 6");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F7       | EXERCÍCIOS 7");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F8       | EXERCÍCIOS 8");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| F9       | EXERCÍCIOS 9");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| ESC      | SAIR                  ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| Selecione os Exercicios conforme as opções do menu |");
                lerTecla = Console.ReadKey();

                if (lerTecla.Key == ConsoleKey.F1 || lerTecla.Key == ConsoleKey.F2 || lerTecla.Key == ConsoleKey.F3 || lerTecla.Key == ConsoleKey.Escape)
                {
                    continua = false;
                }
                else
                {
                    Console.WriteLine("\nOpção errada!\nEscolha uma das opções acima!");
                    Console.ReadKey();
                }

            } while (continua);

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    {
                        int numero, maior, menor, count = 0;
                        bool valores = true;

                        Console.Clear();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| F1       | EXERCÍCIOS 1         |");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine(" ------------------------------------------------------------------ ");
                        Console.WriteLine("|   Digite 7 Valores e vamos descobrir qual o maior e menu numero  |");
                        Console.WriteLine(" ------------------------------------------------------------------ ");
                        Console.WriteLine("\n");

                        do
                        {
                            count++;
                            Console.WriteLine("Informe o numero: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            maior = numero;
                            menor = numero;

                            for (int i = 2; i < 8; i++)
                            {
                                Console.WriteLine("Informe o {0}º numero", i);
                                numero = Convert.ToInt32(Console.ReadLine());

                                if (numero < menor)
                                {
                                    menor = numero;
                                }
                                if (numero > maior)
                                {
                                    maior = numero;
                                }
                            }
                            Console.WriteLine("O menor numero é: {0}", menor);
                            Console.WriteLine("O maior numero é: {0}:", maior);
                            if (count <= 7)
                            {
                                valores = false;
                            }

                        } while (valores);

                    }
                    break;
                case ConsoleKey.F2:
                    {
                        double num, soma, sub, mult, division;
                        bool completada = true;

                        Console.Clear();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| F2       | EXERCÍCIOS 2         |");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine(" ------------------------------------------------------- ");
                        Console.WriteLine("|   Digite um numero para criar sua respectiva tabuada  |");
                        Console.WriteLine(" ------------------------------------------------------- ");
                        Console.WriteLine("\n");

                        Console.WriteLine("Informe um numero para criar a tabuada: ");
                        num = Convert.ToDouble(Console.ReadLine());

                        while (completada)
                        {
                            Console.WriteLine("|------------|");
                            Console.WriteLine(" Tabuada Soma ");
                            Console.WriteLine("|------------|");
                            for (int i = 0; i < 10; i++)
                            {
                                soma = num + i;
                                Console.WriteLine("{0} + {1} = {2}", num, i, soma);
                                if (i <=10)
                                {
                                    completada = false;
                                }
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("|-----------------|");
                            Console.WriteLine(" Tabuada Subtração ");
                            Console.WriteLine("|-----------------|");
                            for (int i = 0; i < 10; i++)
                            {
                                sub = num - i;
                                Console.WriteLine("{0} - {1} = {2}", num, i, sub);
                                if (i <= 10)
                                {
                                    completada = false;
                                }
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("|---------------------|");
                            Console.WriteLine(" Tabuada Multiplicação ");
                            Console.WriteLine("|---------------------|");
                            for (int i = 0; i < 10; i++)
                            {
                                mult = num * i;
                                Console.WriteLine("{0} x {1} = {2}", num, i, mult);
                                if (i <= 10)
                                {
                                    completada = false;
                                }
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("|----------------|");
                            Console.WriteLine(" Tabuada Divisão  ");
                            Console.WriteLine("|----------------|");
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("{0} ÷ {1} = {2}", num, i, Math.Round((num / i),2));
                                if (i <= 10)
                                {
                                    completada = false;
                                }
                            }
                        }


                    }
                    break;
                case ConsoleKey.F3:
                    {
                        int numero, prod, result;
                        bool calculo = true;

                        Console.Clear();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("| F3       | EXERCÍCIOS 3         |");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine(" ----------------------- ");
                        Console.WriteLine("|   Informe um numero:  |");
                        Console.WriteLine(" ----------------------- ");
                        Console.WriteLine("\n");



                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
