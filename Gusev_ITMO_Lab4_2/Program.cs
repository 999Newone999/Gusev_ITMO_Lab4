using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int Positive = 0;
            int Negative = 0;
            int Iteration = 0;
            Console.WriteLine("Ввод последовательности целых чисел. Ввод 0 завершает последовательность. Определение каких чисел в последовательности больше: положительных или отрицательных.");
            do
            {
                Console.Write("Введите член последовательности: ");
                N = Convert.ToInt16(Console.ReadLine());
                Iteration++;
                if (N > 0)
                {
                    Positive++;
                }
                else if (N < 0)
                {
                    Negative++;
                }
                else break;
            } while (N != 0);

            if (Positive > Negative)
            {
                Console.WriteLine("Положительных чисел в последовательности больше, чем отрицательных.");
            }
            else if (Positive < Negative)
            {
                Console.WriteLine("Отрицательных чисел в последовательности больше, чем положительных.");
            }
            else
            {
                if (Iteration == 1)
                {
                    Console.WriteLine("В последовательности одно число, равное 0.");
                }
                else
                {
                    Console.WriteLine("В последовательности положительных чисел столько же, сколько и отрицательных.");
                }
            }
            Console.ReadKey();
        }
    }
}

