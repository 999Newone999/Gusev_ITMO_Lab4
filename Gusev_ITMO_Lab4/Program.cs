using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int Sum = 0;
            Console.Write("Введите целое число: ");
            N = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Sum = Sum + (2 * i - 1);
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
    }
}
