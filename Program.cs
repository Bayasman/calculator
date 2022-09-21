using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Stop = false;
            int operation;
            double a;
            double b;


            while (Stop == false)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.найти факториал числа");
                Console.WriteLine("3.возвести в n число");
                Console.WriteLine("4.Деление");
                Console.WriteLine("5. вычитание ");
                Console.WriteLine("6.деление");
                Console.WriteLine("7.умножение");
                Console.WriteLine("8.1 процент от числа ");
                Console.WriteLine("9.выйти из программы ");

                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        {
                            Console.WriteLine("введите число ");
                             a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("введите число ");
                             b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"результат {a + b}");


                            break;

                        }

                    case 2:
                        {
                            Console.WriteLine("Введите число");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите степень, в которую хотите возвести число");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Math.Pow(a, b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите число");
                            a = Convert.ToDouble(Console.ReadLine());
                            int factorial = 1;
                            for (int i = 2; i <= a; i++) // Вычисление факториала.
                            {
                                factorial *= i;
                            }

                            Console.WriteLine(factorial);
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("введите число ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("введите число ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"результат {a / b}");

                            break;               
                        }
                    case 5:
                        {
                            Console.WriteLine("введите число ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("введите число ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"результат {a - b}");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("введите число ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("введите число ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"результат {a / b}");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("введите число ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("введите число ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"результат {a * b}");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("введите число ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"результат {a / 100}");
                            break;  
                        }
                    case 9:
                        {
                            Stop = true;
                            break;
                        }
                }
            }
        }
    }
}