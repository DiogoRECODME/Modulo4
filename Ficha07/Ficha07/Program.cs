using System;
using System.Collections;
using System.Text;

namespace Ficha07
{
    class Program
    {
        static void Main(string[] args)
        {
            double menu;

            do
            {
                Console.Clear();
                Console.WriteLine("[Ficha 07-ALGORITMOS COM ESTRUTURAS DE CONTROLO]\n");
                Console.WriteLine("Indique qual o exercicio a executar (E.G. 1,1 / 2,2):");
                menu = double.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1.1:
                        exercicioIi();
                        break;

                    case 1.2:
                        exercicioIii();
                        break;

                    case 1.3:
                        exercicioIiii();
                        break;

                    case 1.4:
                        exercicioIiv();
                        break;

                    case 1.5:
                        exercicioIv();
                        break;

                    case 1.6:
                        exercicioIvi();
                        break;

                    case 1.7:
                        exercicioIvii();
                        break;

                    case 1.8:
                        exercicioIviii();
                        break;

                    case 1.9:
                        exercicioIix();
                        break;

                    case 10:
                        exercicioIx();
                        break;

                    default:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

        static void exercicioIi()
        {
            Console.Clear();
            Console.WriteLine("[1-1]\n");

            double nota;

            Console.Write("Introduza a nota:\t");
            nota = double.Parse(Console.ReadLine());

            if(nota <= 9.44)
            {
                Console.WriteLine("Chumbou");
            }
            else
            {
                Console.WriteLine("Passou");
            }

            Console.ReadKey();
        }

        static void exercicioIii()
        {
            Console.Clear();
            Console.WriteLine("[1-2]\n");

            double height,
                    weight,
                    bmi;

            Console.Write("Introduza a altura (CM - E.g. 1,80):\t");
            height = double.Parse(Console.ReadLine());

            Console.Write("Introduza o peso (KG - E.g. 70):\t");
            weight = double.Parse(Console.ReadLine());

            bmi = Math.Round(weight / (height * height), 2);
            bmi = bmi % 1 == 0 ? Math.Round(bmi, 0) : Math.Round(bmi, 2);

            if (bmi < 18.5)
            {
                Console.WriteLine("\n\n[RESULTADO]--> Abaixo do peso");
            }
            else if ((bmi >= 18.5) && (bmi <= 24.9))
            {
                Console.WriteLine("\n\n[RESULTADO]--> Normal");
            }
            else if ((bmi >= 25) && (bmi <= 29.9))
            {
                Console.WriteLine("\n\n[RESULTADO]--> Acima do peso");
            }
            else
            {
                Console.WriteLine("\n\n[RESULTADO]--> Obeso");
            }

            Console.Write(bmi);
            Console.ReadKey();
        }

        static void exercicioIiii()
        {
            Console.Clear();
            Console.WriteLine("[1-3]\n");

            int num;
            
            Console.Write("Introduza um número:\t");
            num = int.Parse(Console.ReadLine());

            if ((num % 3 == 0) && (num % 7 == 0))
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} é múltiplo de 3 e 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} é múltiplo de 3 e não de 7");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} é múltiplo de 7 e não de 3");
            }
            else
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} não é múltiplo de 3 nem de 7");
            }

            Console.ReadKey();
        }

        static void exercicioIiv()
        {
            Console.Clear();
            Console.WriteLine("[1-4]\n");

            double num;

            Console.Write("Introduza um número:\t");
            num = double.Parse(Console.ReadLine());

            if((num >= 30) && (num <= 50))
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} encontra-se entre 30 e 50, inclusive");
            }
            else
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} não se encontra entre 30 e 50, inclusive");
            }


            Console.ReadKey();
        }

        static void exercicioIv()
        {
            Console.Clear();
            Console.WriteLine("[1-5]\n");

            double num;

            Console.Write("Introduza um número:\t");
            num = double.Parse(Console.ReadLine());

            if ((num > 10) && (num < 20))
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} encontra-se entre 10 e 20, exclusive");
            }
            else
            {
                Console.WriteLine($"\n\n[RESULTADO]--> {num} não se encontra entre 10 e 20, exclusive");
            }

            Console.ReadKey();
        }

        static void exercicioIvi()
        {
            Console.Clear();
            Console.WriteLine("[1-6]\n");

            int floor;

            Console.Write("Selecione o andar:\t");
            floor = int.Parse(Console.ReadLine());

            switch (floor)
            {
                case 3:
                case 5:
                    Console.WriteLine("\n\n[RESULTADO]--> Piso indisponível");
                    break;

                case -2:
                case -1:
                case 0:
                case 1:
                case 2:
                case 4:
                case 6:
                    Console.WriteLine($"\n\n[RESULTADO]--> Indo para o piso {floor}");
                    break;

                default:
                    Console.WriteLine("\n\n[RESULTADO]--> Piso não existe");
                    break;
            }

            //Console.WriteLine($"{0}", floor == 3 ? "Piso indisponível" :
            //                          floor == 5 ? "Piso indisponível" :
            //                          floor == -2 ? "Indo para o piso " + floor :
            //                          floor == -1 ? "Indo para o piso " + floor :
            //                          floor == 0  ? "Indo para o piso " + floor :
            //                          floor == 1  ? "Indo para o piso " + floor :
            //                          floor == 2  ? "Indo para o piso " + floor :
            //                          floor == 4  ? "Indo para o piso " + floor :
            //                          floor == 6  ? "Indo para o piso " + floor : "Piso não existente");

            Console.ReadKey();
        }

        static void exercicioIvii()
        {
            //Console.Clear();
            //Console.WriteLine("[1-7]\n");

            double sum = 0;

            #region FOR LOOP

            for (int i = 0; i < 10; i++)
            {
                sumExerciseIvii(ref sum, i);
            }

            afterLoopsExerciseIvii(ref sum);

            #endregion

            #region WHILE LOOP

            sum = 0;
            int j = 0;
            while (j < 10)
            {
                sumExerciseIvii(ref sum, j);
                j++;
            }

            afterLoopsExerciseIvii(ref sum);

            #endregion

            #region DO WHILE LOOP

            sum = 0;
            int x = 0;
            do
            {
                sumExerciseIvii(ref sum, x);
                x++;
            } while (x < 10);

            afterLoopsExerciseIvii(ref sum);

            #endregion
        }

        static void exercicioIviii()
        {
            double price = 0,
                    total = 0;
            int quant = 0;
            string prod = string.Empty,
                    output = string.Empty;

            //for(int i = 0; i < 5; i++)
            //{
            //    productHandlingExerciseIviii(ref prod, ref price, ref quant, ref total, ref output);
            //}

            do
            {
                productHandlingExerciseIviii(ref prod, ref price, ref quant, ref total, ref output);

                header(1, 8);

                Console.WriteLine("[1] - Continuar\n" +
                                  "[0] - Terminar");
            } while (Console.ReadKey().KeyChar != '0');

            header(1, 8);
            Console.WriteLine(output);
            Console.WriteLine($"\nO total das compras foi {total} €");

            Console.ReadKey();
        }

        static void exercicioIix()
        {
            int num,
                length = 0;

            double avg = 0;

            while(true) 
            { 
                header(1, 9);

                Console.Write("Introduza um número [0 - STOP]:\t");
                num = int.Parse(Console.ReadLine());

                if (num == 0) break;

                length++;
                avg += num;
            }

            header(1, 9);

            Console.WriteLine($"A média dos números introduzidos é {decimalHousesFormatter(avg / length)}");

            Console.ReadKey();
        }

        static void exercicioIx()
        {
            double num,
                    total;
            char op;

            for(int i = 0; i < 2; i++)
            {
                

                Console.Write($"Introduza o número {i + 1}:\t");
                num = double.Parse(Console.ReadLine());

                if (i == 1) break;
                else total = num;
            }

            header(1, 10);

            Console.WriteLine("Escolha uma operação\n" +
                              "[+] Soma" +
                              "[-] Subtração" +
                              "[*] Multiplicação" +
                              "[/] Divisão" +
                              "[%] Resto da divisão");

            switch (Console.ReadKey().KeyChar)
            {
                case '+':
                    header(1, 10);
                    Console.WriteLine($"Operação não existe!");
                    break;
                case '-':
                    header(1, 10);
                    Console.WriteLine($"Operação não existe!");
                    break;
                case 'X':
                    header(1, 10);
                    Console.WriteLine($"Operação não existe!");
                    break;
                case '/':
                    header(1, 10);
                    Console.WriteLine($"Operação não existe!");
                    break;
                case '%':
                    header(1, 10);
                    Console.WriteLine($"Operação não existe!");
                    break;
                default:
                    header(1, 10);
                    Console.WriteLine($"Operação não existe!");
                    break;
            }

            Console.ReadKey();
        }

        #region PRIVATE METHODS

        private static void header(int num, int alinea)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine($"[{num}-{alinea}]\n");
        }

        private static void sumExerciseIvii(ref double sum, in int i)
        {
            Console.Clear();
            Console.WriteLine("[1-7]\n");
            Console.Write($"Introduza o número {i + 1}:\t");
            sum += double.Parse(Console.ReadLine());
        }

        private static void afterLoopsExerciseIvii(ref double sum)
        {
            Console.Clear();
            Console.WriteLine("[1-7]\n");
            sum = sum % 1 == 0 ? Math.Round(sum, 0) : Math.Round(sum, 2);
            Console.WriteLine($"\n\n[RESULTADO]--> {sum}");
            Console.ReadKey();
        }

        private static double decimalHousesFormatter(in double num)
        {
            return num % 1 == 0 ? Math.Round(num, 0) : Math.Round(num, 2);
        }

        private static void productHandlingExerciseIviii(ref string prod,
                                                         ref double price,
                                                         ref int quant,
                                                         ref double total,
                                                         ref string output)
        {
            header(1, 8);

            Console.Write($"Introduza um produto:\t");
            prod = Console.ReadLine();

            Console.Write($"Introduza o preço de cada {prod} [€]:\t");
            price = decimalHousesFormatter(double.Parse(Console.ReadLine()));
            
            Console.Write($"Introduza a quantidade de {prod}:\t");
            quant = int.Parse(Console.ReadLine());

            total += decimalHousesFormatter((price * quant));
            output += ($"{quant} {prod} custam {(price * quant)} €\n");

            Console.ReadKey();
        }

        #endregion
    }
}