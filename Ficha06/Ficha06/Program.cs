using System;
using System.Collections;

namespace Ficha06
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicioIi();

            //exercicioIii();

            //exercicioIiii();

            //exercicioIiv();

            //exercicioIv();

            //exercicioIvi();

            //exercicioIvii();
            
            //exercicioIviii();
            
            //exercicioIix();
            
            //exercicioIx();

            //exercicioIxi();
            
            //exercicioIIi();
            
            //exercicioIIii();
            
            //exercicioIIiii();

            //exercicioIIIi();

            //exercicioIIIii();
            
        }

        static void exercicioIi()
        {
            Console.Clear();
            Console.WriteLine("[1-1]\n");

            string name;

            Console.Write("Introduza o seu nome:\t");
            name = Console.ReadLine();

            Console.WriteLine("\n\n[RESULTADO]--> Olá {0}", name);
            //Console.WriteLine(@"Olá {0}", name);
            //Console.WriteLine($"Olá {name}");

            Console.ReadKey();
        }

        static void exercicioIii()
        {
            Console.Clear();
            Console.WriteLine("[1-2]\n");

            double sum,
                    num1,
                    num2;

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("\n\n[RESULTADO]--> {0}",sum);

            Console.ReadKey();
        }

        static void exercicioIiii()
        {
            Console.Clear();
            Console.WriteLine("[1-3]\n");

            double sum,
                    num1,
                    num2,
                    num3,
                    num4,
                    num5,
                    num6,
                    num7,
                    num8,
                    num9,
                    num10;

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 4:\t");
            num4 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 5:\t");
            num5 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 6:\t");
            num6 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 7:\t");
            num7 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 8:\t");
            num8 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 9:\t");
            num9 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 10:\t");
            num10 = double.Parse(Console.ReadLine());

            sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;

            Console.WriteLine("\n\n[RESULTADO]--> {0}", sum);

            Console.ReadKey();
        }

        static void exercicioIiv()
        {
            Console.Clear();
            Console.WriteLine("[1-4]\n");

            double temp,
                    num1,
                    num2;

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n\n[RESULTADO]--> A={0} & B={1}", num1, num2);

            Console.ReadKey();
        }

        static void exercicioIv()
        {
            double num1,
                    num2,
                    num3,
                    num4,
                    num5,
                    num6;

            Console.Clear();
            Console.WriteLine("[1-5]\n\nA)");

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]--> {0}", num1 + (num2*num3));

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[1-5]\n\nB)");

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]--> {0}", (num1 + num2) % num3);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[1-5]\n\nC)");

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 4:\t");
            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]--> {0}", num1 + ((num2 * num3) / num4));

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[1-5]\n\nD)");

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 4:\t");
            num4 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 5:\t");
            num5 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 6:\t");
            num6 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]--> {0}", num1 + ((num2 / num3) * (num4 - (num5 / num6))));

            Console.ReadKey();
        }

        static void exercicioIvi()
        {
            Console.Clear();
            Console.WriteLine("[1-6]\n");

            double num;

            Console.Write("Introduza um número:\t");
            num = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]-->");
            Console.WriteLine("\t{0} X 1 = {1}", num, (num * 1));
            Console.WriteLine("\t{0} X 2 = {1}", num, (num * 2));
            Console.WriteLine("\t{0} X 3 = {1}", num, (num * 3));
            Console.WriteLine("\t{0} X 4 = {1}", num, (num * 4));
            Console.WriteLine("\t{0} X 5 = {1}", num, (num * 5));
            Console.WriteLine("\t{0} X 6 = {1}", num, (num * 6));
            Console.WriteLine("\t{0} X 7 = {1}", num, (num * 7));
            Console.WriteLine("\t{0} X 8 = {1}", num, (num * 8));
            Console.WriteLine("\t{0} X 9 = {1}", num, (num * 9));
            Console.WriteLine("\t{0} X 10 = {1}", num, (num * 10));

            Console.ReadKey();
        }

        static void exercicioIvii()
        {
            Console.Clear();
            Console.WriteLine("[1-7]\n");

            double num1,
                    num2,
                    avg;

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            avg = num1 + num2;
            avg /= 2;

            Console.WriteLine("\n\n[RESULTADO]--> A média é {0}", avg);

            Console.ReadKey();
        }

        static void exercicioIviii()
        {
            Console.Clear();
            Console.WriteLine("[1-8]\n");

            double num1,
                    num2,
                    num3,
                    num4,
                    num5,
                    avg;

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());
            
            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());
            
            Console.Write("Introduza o número 4:\t");
            num4 = double.Parse(Console.ReadLine());
            
            Console.Write("Introduza o número 5:\t");
            num5 = double.Parse(Console.ReadLine());

            avg = num1 + num2 + num3 + num4 + num5;
            avg /= 5;

            Console.WriteLine("\n\n[RESULTADO]--> A média é {0}", avg);

            Console.ReadKey();
        }

        static void exercicioIix()
        {
            Console.Clear();
            Console.WriteLine("[1-9]\n");

            double num1,
                    num2,
                    num3,
                    num4,
                    num5,
                    num6,
                    num7,
                    num8,
                    num9,
                    num10,
                    avg;

            Console.Write("Introduza o número 1:\t");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 2:\t");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 3:\t");
            num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 4:\t");
            num4 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 5:\t");
            num5 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 6:\t");
            num6 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 7:\t");
            num7 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 8:\t");
            num8 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 9:\t");
            num9 = double.Parse(Console.ReadLine());

            Console.Write("Introduza o número 10:\t");
            num10 = double.Parse(Console.ReadLine());

            avg = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            avg /= 10;

            Console.WriteLine("\n\n[RESULTADO]--> A média é {0}", avg);

            Console.ReadKey();
        }

        static void exercicioIx()
        {
            Console.Clear();
            Console.WriteLine("[1-10]\n");

            char c;

            Console.Write("Introduza um caracter:\t");
            c = char.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]-->");
            Console.WriteLine("\t{0}{1}{2}", c, c, c);
            Console.WriteLine("\t{0}{1}{2}", c, c, c);
            Console.WriteLine("\t{0}{1}{2}", c, c, c);
            
            Console.ReadKey();
        }

        static void exercicioIxi()
        {
            Console.Clear();
            Console.WriteLine("[1-11]\n");

            string name1,
                    name2,
                    name3;

            double price1,
                    price2,
                    price3;

            int quant1,
                quant2,
                quant3;

            #region 1st product
            Console.Write("Introduza o nome do 1º produto:\t");
            name1 = Console.ReadLine();

            Console.Write("Introduza o preço do 1º produto:\t");
            price1 = double.Parse(Console.ReadLine());

            Console.Write("Introduza a quantidade do 1º produto:\t");
            quant1 = int.Parse(Console.ReadLine());
            #endregion

            Console.Clear();
            Console.WriteLine("[1-11]\n");

            #region 2nd product
            Console.Write("Introduza o nome do 2º produto:\t");
            name2 = Console.ReadLine();

            Console.Write("Introduza o preço do 2º produto:\t");
            price2 = double.Parse(Console.ReadLine());

            Console.Write("Introduza a quantidade do 2º produto:\t");
            quant2 = int.Parse(Console.ReadLine());
            #endregion

            Console.Clear();
            Console.WriteLine("[1-11]\n");

            #region 3rd product
            Console.Write("Introduza o nome do 3º produto:\t");
            name3 = Console.ReadLine();

            Console.Write("Introduza o preço do 3º produto:\t");
            price3 = double.Parse(Console.ReadLine());

            Console.Write("Introduza a quantidade do 3º produto:\t");
            quant3 = int.Parse(Console.ReadLine());
            #endregion

            Console.Clear();
            Console.WriteLine("[1-11]\n");

            Console.WriteLine("\n\n[RESULTADO]-->");
            Console.WriteLine("\t{0} {1} custam {2}€", quant1, name1, (quant1 * price1));
            Console.WriteLine("\t{0} {1} custam {2}€", quant2, name2, (quant2 * price2));
            Console.WriteLine("\t{0} {1} custam {2}€", quant3, name3, (quant3 * price3));
            Console.WriteLine("\n\tO total da compra é {0}€", (quant1 * price1) + (quant2 * price2) + (quant3 * price3));

            Console.ReadKey();
        }

        static void exercicioIIi()
        {
            Console.Clear();
            Console.WriteLine("[2-1]\n");

            string phrase;

            Console.Write("Diz me algo que eu não saiba:\t");
            phrase = Console.ReadLine();

            Console.WriteLine("\n\n[RESULTADO]--> Eu já sabia que {0}.", phrase);
            
            Console.ReadKey();
        }

        static void exercicioIIii()
        {
            Console.Clear();
            Console.WriteLine("[2-2]\n");

            int fstName,
                lstName;

            Console.Write("Introduz o número 1:\t");
            fstName = int.Parse(Console.ReadLine());

            Console.Write("Introduz o número 2:\t");
            lstName = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n[RESULTADO]--> O primeiro número é {0} e o segundo número é {1}.", fstName, lstName);

            Console.ReadKey();
        }

        static void exercicioIIiii()
        {
            Console.Clear();
            Console.WriteLine("[2-3]\n");

            double temp,
                    tempF,
                    tempK;

            Console.Write("Introduz a temperatura:\t");
            temp = double.Parse(Console.ReadLine());

            tempF = ((temp * 9) / 5) + 32;
            tempK = temp + 273.15;

            Console.WriteLine("\n\n[RESULTADO]--> A temperatura é {0}ºC é {1}ºF e {2}ºK", temp, tempF, tempK);

            Console.ReadKey();
        }

        static void exercicioIIIi()
        {
            Console.Clear();
            Console.WriteLine("[3-1]\n");

            int horas,
                minutos,
                segundos,
                total;

            Console.Write("Quantas horas?\t");
            horas = int.Parse(Console.ReadLine());

            Console.Write("Quantos minutos?\t");
            minutos = int.Parse(Console.ReadLine());
            
            Console.Write("Quantos segundos?\t");
            segundos = int.Parse(Console.ReadLine());

            total = (horas * 3600) + (minutos * 60) + segundos;

            Console.WriteLine($"\n\n[RESULTADO]--> {horas}:{minutos}:{segundos} é equivalente a {total} segundos");

            Console.ReadKey();
        }

        static void exercicioIIIii()
        {
            Console.Clear();
            Console.WriteLine("[3-2]\n");

            double raio,
                    perimetro,
                    area;

            Console.Write("Qual é o raio?\t");
            raio = double.Parse(Console.ReadLine());

            perimetro = 2 * 3.14 * raio;
            area = 3.14 * raio * raio;

            Console.WriteLine($"\n\n[RESULTADO]--> A área do circulo é {area} e o perímetro é {perimetro}");

            Console.ReadKey();
        }
    }
}
