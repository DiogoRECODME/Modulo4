using System;
using Common;
using UsefulFunctions;

namespace Ficha12
{
    public class F12G1
    {

        public static void Ex1()
        {
            double total = 1.0;
            string output = string.Empty;

            for(int i = 0; i < 3; i++)
            {
                Functions.Header(1, 1);

                double currentNumber = Functions.DecimalHousesFormatter(InputRequest.RequestDouble("Introduza um número:\t"));
                total *= currentNumber;

                output += $"{currentNumber}";
                if(i < 2)
                    output += $" x";
                output += " ";
            }

            Functions.Header(1, 1);
            Console.WriteLine($"{output}= {total}");
            Console.ReadKey();
        }

        public static void Ex2()
        {
            Functions.Header(1, 2);

            double firstNumber = Functions.DecimalHousesFormatter(InputRequest.RequestDouble("Introduza o 1º número:\t"));
            double secondNumber = Functions.DecimalHousesFormatter(InputRequest.RequestDouble("Introduza o 2º número:\t"));

            Console.WriteLine($"{firstNumber} + {secondNumber} = {(firstNumber + secondNumber)}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {(firstNumber - secondNumber)}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {(firstNumber * secondNumber)}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {(firstNumber / secondNumber)}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {(firstNumber % secondNumber)}");
        }

        public static void Ex4()
        {
            Functions.Header(1, 3);

            Console.Write("Introduza um número:\t");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                bool isPrime = true;

                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write("\n" + i + " ");
            }
        }

        public static void Ex7()
        {
            int year;

            do
            {
                Functions.Header(1, 7);

                year = InputRequest.RequestInteger("Introduza um ano para ver se é bissexto:\t");
            } while (year < 0);

            Functions.Header(1, 7);

            if (Functions.LeapYearValidator(year))
                Console.WriteLine($"{year} é bissexto");
            else
                Console.WriteLine($"{year} não é bissexto"); 
        }

        public static void Ex8()
        {
            Functions.Header(1, 8);

            for(int i = 99; i > 0; i--)
            {
                if (i != 1)
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.\n" +
                                      $"Take one down and pass it around, {i - 1} bottles of beer on the wall.\n");
                else
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.\n" +
                                     $"Take one down and pass it around, nome more bottles of beer on the wall.\n\n" +
                                     $"No more bottles of beer on the wall, no more bootles of beer.\n" +
                                     $"Go to the store and buy some more, 99 bottles of beer on the wall.");
            }
        }

        public static void Ex9()
        {
            Functions.Header(1, 9);

            Console.WriteLine(Functions.TriangleTypeByDegrees(InputRequest.RequestDouble("Introduza o 1º ângulo"), InputRequest.RequestDouble("Introduza o 2º ângulo"), InputRequest.RequestDouble("Introduza o 3º ângulo")));
        }

        public static void Ex10()
        {
            Functions.Header(1, 10);

            if (Functions.ProfitCheck(InputRequest.RequestDouble("Introduza a quantidade inicial:\t"),
                                      InputRequest.RequestDouble("Introduza a quantidade inicial:\t"), 
                                      out double diff))
            {
                Functions.Header(1, 10);
                Console.WriteLine($"Obteve um lucro de {diff}.");
            }
            else
            {
                Functions.Header(1, 10);
                if (diff == 0)
                    Console.WriteLine("Não obteve lucro nem prejuízo.");
                else
                    Console.WriteLine($"Obteve um prejuízo de {diff}.");
            }
        }

        public static void Ex16()
        {
            int min = 1,
                max = 100;
            bool numeroCerto = false;

            while (!numeroCerto)
            {
                Functions.Header(1, 16);
                Console.WriteLine();
                var avg = (int)Math.Floor((double)(min + max) / 2);
                var intConf = max - min;
                var keyOk = false;

                if(intConf < 2)
                {
                    for(int i = min; i < (max + 1); i++)
                    {
                        Functions.Header(1, 16);
                        Console.WriteLine($"É {i}?");
                        var key = Console.ReadKey().Key;

                        if(key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            numeroCerto = true;
                            break;
                        }
                        Console.WriteLine("");
                    }
                }

                if (!numeroCerto)
                {
                    while (!keyOk)
                    {
                        Functions.Header(1, 16);
                        Console.WriteLine($"O número é inferior a {avg}?");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.S:
                                keyOk = true;
                                max = avg - 1;
                                break;

                            case ConsoleKey.N:
                                keyOk = true;
                                min = avg;
                                break;

                            default:
                                Console.CursorTop = Console.CursorTop - 1;
                                Console.CursorLeft = 0;
                                Console.WriteLine(new string(' ', Console.WindowWidth));
                                Console.CursorTop = Console.CursorTop - 1;
                                break;
                        }
                    }
                }
            }
        }

    }
}