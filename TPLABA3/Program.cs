using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABA3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] IN = new double[3];

            Console.WriteLine("Выберите, что вы хотите проверить (1 - проверить тени, 2 - проверить треугольник)");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Введите длину первого массива: ");
                    int N1 = 0;
                    N1 = Convert.ToInt32(Console.ReadLine());
                    double[] S11 = new double[N1];
                    double[] S12 = new double[N1];

                    Console.WriteLine("Введите отрезки S1: ");

                    for (int i = 0; i < N1; i++)
                    {
                        Console.WriteLine("Введите отрезки X: ");
                        S11[i] = CIN();
                        S12[i] = CIN();
                    }

                    Console.WriteLine("Введите длину второго массива: ");
                    N1 = Convert.ToInt32(Console.ReadLine());
                    double[] S21 = new double[N1];
                    double[] S22 = new double[N1];

                    Console.WriteLine("Введите отрезки S2: ");

                    for (int i = 0; i < N1; i++)
                    {
                        Console.WriteLine("Введите отрезки X: ");
                        S21[i] = CIN();
                        S22[i] = CIN();
                    }

                    Console.WriteLine("Длина тени S1: ");
                    Console.WriteLine(CreateX(S11, S12));

                    Console.WriteLine("Длина тени S2: ");
                    Console.WriteLine(CreateX(S21, S22));

                    Console.ReadLine(); break;

                case 2:
                    Console.WriteLine("Введите длины сторон:");

                    for (int i = 0; i < 3; i++) IN[i] = CIN();

                    switch (Triangle.IsTriange(IN))
                    {
                        case 0: Console.WriteLine("Треугольник равносторонний"); break;
                        case 1: Console.WriteLine("Треугольник равнобедренный"); break;
                        case 2: Console.WriteLine("Треугольник прямоугольный"); break;
                        case 3: Console.WriteLine("Треугольник разносторонний"); break;
                    }
                    break;
            }
            Console.ReadLine();
        }

        static double CIN()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double CreateX(double[] S11, double[] S12)
        {
            double shadow = 0;
            double[] ar = new double[2]; ar[0] = S11[0];

            for (int i = 0; i < S11.Length - 1; i++)
            {
                if ((S11[i + 1] <= S12[i]) && (S12[i + 1] >= S12[i])) ar[1] = S12[i + 1];
                else break;
            }

            return shadow = ar[1] - ar[0];
        }
    }
}