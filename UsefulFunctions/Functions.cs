using System;
using System.Text;

namespace UsefulFunctions
{
    public class Functions
    {
        public static void Header(int num, int alinea)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine($"[{num}-{alinea}]\n");
        }

        public static double DecimalHousesFormatter(in double num)
        {
            return num % 1 == 0 ? Math.Round(num, 0) : Math.Round(num, 2);
        }

        public static bool LeapYearValidator(in int year)
        {
            if (year % 4 == 0)
                if((year % 400 == 0) || (year % 100 != 0))
                return true;
            return false;
        }

        public static string TriangleTypeByDegrees(double deg1, double deg2, double deg3)
        {
            if ((deg1 + deg2 + deg3) != 180)
                return "Triângulo Inválido";
            else
            {
                if ((deg1 == deg2) && (deg1 == deg3))
                    return "O triângulo é equilátero.";
                else if ((deg1 != deg2) && (deg2 != deg3) && (deg1 != deg3))
                    return "O triângulo é escaleno.";
                else
                    return "O triângulo é isósceles.";
            }
        }

        public static bool ProfitCheck(in double firstAmount, in double lastAmount, out double diff)
        {
            diff = Functions.DecimalHousesFormatter(lastAmount - firstAmount);

            if (diff > 0)
                return true;
            else
                return false;
        }

    }
}
