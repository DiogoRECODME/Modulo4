using System;
using System.Threading;

namespace PPT
{
    public class PedraPapelTesoura
    {

        public static void Start()
        {
            int rounds,
                    playerWins = 0,
                    cpuWins = 0,
                    cpuPlay,
                    target;
            char play;
            string name;

            do
            {
                Console.Write("\nIntroduza a quantidade de rondas (tem que ser impar):\t");
                int.TryParse(Console.ReadLine(), out rounds);
            } while (rounds % 2 == 0);
            target = (rounds / 2) + 1;
            
            Console.Clear();
            Console.Write("\nIntroduza o nome do jogador :\t");
            name = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine($"{name} --> {playerWins}\n" +
                                  $"CPU --> {cpuWins}\n\n" +
                                  $"O primeiro a {target} rondas ganha!");

                Console.WriteLine("\n\n[1] - Pedra\n" +
                                      "[2] - Papel\n" +
                                      "[3] - Tesoura");

                play = Console.ReadKey().KeyChar;

                cpuPlay = RandomGenerator(1, 3);

                Console.Clear();

                switch (play)
                {
                    case '1':
                        if (cpuPlay == 1)
                            Console.WriteLine("Empate!\n\n" +
                                              "Ambos jogaram Pedra!");
                        else if (cpuPlay == 2)
                        {
                            Console.WriteLine("Ronda para o CPU!\n\n" +
                                             $"{name} jogou Pedra!\n" +
                                              "CPU jogou Papel!");
                            cpuWins++;
                        }
                        else
                        {
                            Console.WriteLine($"Ronda para o {name}!\n\n" +
                                              $"{name} jogou Pedra!\n" +
                                               "CPU jogou Tesoura!");
                            playerWins++;
                        }
                        break;

                    case '2':
                        if (cpuPlay == 1)
                        {
                            Console.WriteLine($"Ronda para o {name}!\n\n" +
                                              $"{name} jogou Papel!\n" +
                                               "CPU jogou Pedra!");
                            playerWins++;
                        }
                        else if (cpuPlay == 2)
                            Console.WriteLine("Empate!\n\n" +
                                              "Ambos jogaram Papel!");
                        else
                        {
                            Console.WriteLine("Ronda para o CPU!\n\n" +
                                             $"{name} jogou Papel!\n" +
                                              "CPU jogou Tesoura!");
                            cpuWins++;
                        }
                        break;

                    case '3':
                        if (cpuPlay == 1)
                        {
                            Console.WriteLine("Ronda para o CPU!\n\n" +
                                             $"{name} jogou Tesoura!\n" +
                                              "CPU jogou Pedra!");
                            cpuWins++;
                        }
                        else if (cpuPlay == 2)
                        {
                            Console.WriteLine($"Ronda para o {name}!\n\n" +
                                              $"{name} jogou Tesoura!\n" +
                                               "CPU jogou Papel!");
                            playerWins++;
                        }
                        else
                            Console.WriteLine("Empate!\n\n" +
                                              "Ambos jogaram Tesoura!");
                        break;

                    default:
                        break;
                }
                Console.ReadKey();

            } while ((playerWins < target) && (cpuWins < target));

            Console.Clear();
            if (playerWins == target)
                Console.WriteLine($"O jogador {name} ganhou ao CPU [{playerWins} - {cpuWins}]");
            else
                Console.WriteLine($"O CPU ganhou ao jogador {name} [{playerWins} - {cpuWins}]");

        }

        private static int RandomGenerator(int min, int max)
        {
            return new Random().Next(max) + min;
        }

    }
}
