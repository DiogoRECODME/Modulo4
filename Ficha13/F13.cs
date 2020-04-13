using System;
using UsefulFunctions;

namespace Ficha13
{
    public class F13
    {

        public static void Ex1()
        {
            double num1,
                    num2;
            char op;

            char status;

            while (true)
            {
                do
                {
                    header("CALCULADORA");
                    Console.Write("Introduza o primeiro número:\t");
                } while (!double.TryParse(Console.ReadLine(),out num1));

                do
                {
                    header("CALCULADORA");
                    Console.Write("Introduza a operação:\t");
                } while (!char.TryParse(Console.ReadLine(),out op));

                do
                {
                    header("CALCULADORA");
                    Console.Write("Introduza o segundo número:\t");
                } while (!double.TryParse(Console.ReadLine(), out num2));

                switch (op)
                {
                    case '+':
                        header("CALCULADORA");
                        Console.WriteLine($"{Functions.DecimalHousesFormatter(num1)} {op} {Functions.DecimalHousesFormatter(num2)} == {Functions.DecimalHousesFormatter(num1 + num2)}");
                        break;

                    case '-':
                        header("CALCULADORA");
                        Console.WriteLine($"{Functions.DecimalHousesFormatter(num1)} {op} {Functions.DecimalHousesFormatter(num2)} == {Functions.DecimalHousesFormatter(num1 - num2)}");
                        break;

                    case '*':
                        header("CALCULADORA");
                        Console.WriteLine($"{Functions.DecimalHousesFormatter(num1)} {op} {Functions.DecimalHousesFormatter(num2)} == {Functions.DecimalHousesFormatter(num1 * num2)}");
                        break;

                    case '/':
                        header("CALCULADORA");
                        Console.WriteLine($"{Functions.DecimalHousesFormatter(num1)} {op} {Functions.DecimalHousesFormatter(num2)} == {Functions.DecimalHousesFormatter(num1 / num2)}");
                        break;

                    case '%':
                        header("CALCULADORA");
                        Console.WriteLine($"{Functions.DecimalHousesFormatter(num1)} {op} {Functions.DecimalHousesFormatter(num2)} == {Functions.DecimalHousesFormatter(num1 % num2)}");
                        break;

                    default:
                        header("CALCULADORA");
                        Console.WriteLine($"{op} não é uma operação válida!");
                        break;
                }

                Console.ReadKey();

                do
                {
                    header("CALCULADORA");
                    Console.WriteLine("[1] - Continuar\n" +
                                      "[0] - Terminar");

                    status = Console.ReadKey().KeyChar;
                } while (status != '1' && status != '0');

                if (status == '0')
                {
                    header("CALCULADORA");
                    Console.WriteLine("Terminar...");
                    break;
                }
                    
            }
        }

        public static void Ex2()
        {
            while (true)
            {
                char a = '0',
                    b = '0',
                    c = '0',
                    d = '0',
                    e = '0',
                    f = '0',
                    g = '0',
                    h = '0',
                    i = '0',
                    play;
                int player = 1;

                header("JOGO DO GALO");
                Console.WriteLine("[1] - Jogar\n" +
                                  "[2] - Regras");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        do {
                            header("JOGO DO GALO");
                            board(a, b, c, d, e, f, g, h, i);

                            Console.WriteLine($"\n\n\nVez do jogador:\t [{player}]");
                            play = Console.ReadKey().KeyChar;

                            
                            if ((play == '1' && a == '0') ||
                                (play == '2' && b == '0') ||
                                (play == '3' && c == '0') ||
                                (play == '4' && d == '0') ||
                                (play == '5' && e == '0') ||
                                (play == '6' && f == '0') ||
                                (play == '7' && g == '0') ||
                                (play == '8' && h == '0') ||
                                (play == '9' && i == '0'))
                            {

                                if (play == '1')
                                    a = char.Parse(player.ToString());
                                else if (play == '2')
                                    b = char.Parse(player.ToString());
                                else if (play == '3')
                                    c = char.Parse(player.ToString());
                                else if (play == '4')
                                    d = char.Parse(player.ToString());
                                else if (play == '5')
                                    e = char.Parse(player.ToString());
                                else if (play == '6')
                                    f = char.Parse(player.ToString());
                                else if (play == '7')
                                    g = char.Parse(player.ToString());
                                else if (play == '8')
                                    h = char.Parse(player.ToString());
                                else
                                    i = char.Parse(player.ToString());
                            }

                            if (checkWinner(player, a, b, c, d, e, f, g, h, i))
                            {
                                header("JOGO DO GALO");
                                board(a, b, c, d, e, f, g, h, i);
                                Console.WriteLine($"\n\nO JOGADOR {player} GANHOU!");
                                Console.ReadKey();
                                break;
                            }
                            else if (player == 1)
                                player = 2;
                            else
                                player = 1;

                        } while (true);
                        break;

                    case '2':
                        header("JOGO DO GALO");
                        Console.WriteLine("Os números do NumPad equivalem ao tabuleiro.\n" +
                                          "Cada jogador joga uma vez de acordo com o indicador de jogador em cima do tabuleiro.\n\n" +
                                          "A ordem é a seguinte:    7 - 8 - 9\n" +
                                                            "\t\t\t 4 - 5 - 6\n" +
                                                            "\t\t\t 1 - 2 - 3");
                        break;

                    default:
                        break;
                }
                
                Console.ReadKey();
            }
        }






        // PRIVATE METHODS

        private static void header(string name)
        {
            Console.Clear();
            Console.WriteLine($"{name}\n\n");
        }

        private static void board(in char a,
                                 in char b,
                                 in char c,
                                 in char d,
                                 in char e,
                                 in char f,
                                 in char g,
                                 in char h,
                                 in char i)
        {
            Console.WriteLine("\t\t     |     |     \n" +
                             $"\t\t  {g}  |  {h}  |  {i} \n" +
                              "\t\t_____|_____|_____\n" +
                              "\t\t     |     |     \n" +
                             $"\t\t  {d}  |  {e}  |  {f} \n" +
                              "\t\t_____|_____|_____\n" +
                              "\t\t     |     |     \n" +
                             $"\t\t  {a}  |  {b}  |  {c} \n" +
                              "\t\t     |     |");
        }

        private static bool checkWinner(in int player,
                                        in char a,
                                        in char b,
                                        in char c,
                                        in char d,
                                        in char e,
                                        in char f,
                                        in char g,
                                        in char h,
                                        in char i)
        {
            if ((g == char.Parse(player.ToString())) &&
                (h == char.Parse(player.ToString())) &&
                (i == char.Parse(player.ToString())))
                return true;

            if ((d == char.Parse(player.ToString())) &&
                (e == char.Parse(player.ToString())) &&
                (f == char.Parse(player.ToString())))
                return true;

            if ((a == char.Parse(player.ToString())) &&
                (b == char.Parse(player.ToString())) &&
                (c == char.Parse(player.ToString())))
                return true;

            if ((g == char.Parse(player.ToString())) &&
                (d == char.Parse(player.ToString())) &&
                (a == char.Parse(player.ToString())))
                return true;

            if ((h == char.Parse(player.ToString())) &&
                (e == char.Parse(player.ToString())) &&
                (b == char.Parse(player.ToString())))
                return true;

            if ((i == char.Parse(player.ToString())) &&
                (f == char.Parse(player.ToString())) &&
                (c == char.Parse(player.ToString())))
                return true;

            if ((g == char.Parse(player.ToString())) &&
                (e == char.Parse(player.ToString())) &&
                (c == char.Parse(player.ToString())))
                return true;

            if ((i == char.Parse(player.ToString())) &&
                (e == char.Parse(player.ToString())) &&
                (a == char.Parse(player.ToString())))
                return true;

            return false;
        }


    }
}
