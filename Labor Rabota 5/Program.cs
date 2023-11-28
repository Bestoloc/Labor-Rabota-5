using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_Rabota_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X = ");
            double x = double.Parse(Console.ReadLine());
            const double E = 0.001;
            double A = x * 0.5;
            double S = 0;
            int n = 0;
            do
            {
                S = S + A;
                Console.WriteLine(S);
                n++;
                A = A * (n + 1) / (n * (n + 3));
            }
            while (A >= E);
            Console.WriteLine($"Сумма членов ряда S={S:f6} число итераций n={n}");
            Console.ReadKey();
        }
    }
}
