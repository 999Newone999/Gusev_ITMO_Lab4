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
            double A=0;
            double B=0;
            double C=0;
            double A_compare=0;
            double B_compare=0;
            int Number = 0;
            bool status_ok = false;

            while (status_ok == false)
            {
                Console.Write("Введите сторону прямоугольника А: ");
                A = Convert.ToDouble(Console.ReadLine());
                if (A < 0)
                {
                    Console.WriteLine("Cторона прямоугольника А должна быть положительным числом.");
                    status_ok = false;
                }
                else 
                {
                    status_ok = true;
                }
            }

            status_ok = false;
            while (status_ok == false)
            {
                Console.Write("Введите сторону прямоугольника B: ");
                B = Convert.ToDouble(Console.ReadLine());
                if (B < 0)
                {
                    Console.WriteLine("Cторона прямоугольника B должна быть положительным числом.");
                    status_ok = false;
                }
                else
                {
                    status_ok = true;
                }
            }

            status_ok = false;
            while (status_ok == false)
            {
                Console.Write("Введите сторону квадрата C: ");
                C = Convert.ToDouble(Console.ReadLine());
                if (C < 0)
                {
                    Console.WriteLine("Cторона прямоугольника B должна быть положительным числом.");
                    status_ok = false;
                }
                else
                {
                    if (C > A)
                    {
                        Console.WriteLine("Cторона квадрата С должна быть меньше стороны прямоугольника A.");
                        status_ok = false;
                    }
                    else if (C > B)
                    {
                        Console.WriteLine("Cторона квадрата С должна быть меньше стороны прямоугольника B.");
                        status_ok = false;
                    }
                    else
                    {
                        status_ok = true;
                    }
                }
            }

            while ((A - A_compare) >= C)
            {
                B_compare = 0;
                while ((B - B_compare) >= C)
                {
                    B_compare = B_compare + C;
                    Number++;
                }
                A_compare = A_compare + C;
            }
            Console.WriteLine("В прямоугольнике состоронами A = {1} и B = {2} содержится {0} квадратов со стороной С = {3}.", Number, A, B, C);
            Console.ReadKey();
        }
    }
}
