using System;
using System.Collections;

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
    }
}
