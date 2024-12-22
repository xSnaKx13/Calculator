using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            string operation = "";
            double result = 0;
            bool atWork = true;

            while (atWork)
            {
                bool userChoise = true;
                Console.Clear();
                Console.Write("Введите первое число: ");
                try
                {
                    firstNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Введено некорректное значение");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Введите второе число: ");
                try
                {
                    secondNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Введено некорректное значение");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Введите операцию (*, /, +, -): ");
                try
                {
                    operation = Console.ReadLine();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Введено некорректное значение");
                    Console.ReadKey();
                    continue;
                }

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        Console.Clear();
                        Console.WriteLine($"Результат операции {result}");
                        Console.ReadKey();
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        Console.Clear();
                        Console.WriteLine($"Результат операции {result}");
                        Console.ReadKey();
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        Console.Clear();
                        Console.WriteLine($"Результат операции {result}");
                        Console.ReadKey();
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("На ноль делить неляьзя");
                            Console.ReadKey();
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            Console.Clear();
                            Console.WriteLine($"Результат операции {result}");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Введена некорректная операция");
                        Console.ReadKey();
                        continue;
                }
                while (userChoise)
                {
                    Console.WriteLine("Продолжить выполнение программы - 1");
                    Console.WriteLine("Прекратить выполнение программы - 2");
                    int actionSelection = int.Parse(Console.ReadLine());
                    if (actionSelection == 1)
                    {
                        atWork = true;
                        userChoise = false;
                    }
                    else if (actionSelection != 1 && actionSelection != 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Введено некорректное значение");
                        Console.ReadKey();
                        userChoise = true;
                    }
                    else
                    {
                        atWork = false;
                        userChoise = false;
                        Console.Clear();
                        Console.WriteLine("Для закрытия нажмите любую кнопку...");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
