using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void printMas(double[,] mas, int n, int m, string s)
        {
            Console.WriteLine(s);
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write("{0,5:N2}\t", mas[i, j]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            const double a = 10, b = 50;
            int i;
            const int n = 4, m = 4;
            double[,] mas = new double[n, m] { { -72, 36, -41, 54 }, { 26, 37, 19, 18 }, { -16, -21, -13, -24 }, { 61, -58, 33, 16 } };
            printMas(mas, n, m, "Початковий масив->");
            int k;
            if (n == m || n < m)
                k = n;
            else
                k = m;
            double sumaMAS = 0;
            double dobutokMas = 1;
            int nn = 0, mm = 0, mmm = m - 1;
            for (i = 0; i < k; i++)
            {
                sumaMAS += mas[nn, mm];//по головнiй дiагоналi
                dobutokMas *= mas[nn, mmm];//по побiчнiй дiагоналi
                nn++; mm++; mmm--;
            }
            Console.WriteLine($"Сума елементiв першої дiагоналi масиву дорiвнює: {sumaMAS:F2}\n" +
                $"Добуток елементiв другої дiагоналi масиву дорiвнює(61*(-21): {dobutokMas:F2}");
            Console.ReadKey();
        }
    }
}
