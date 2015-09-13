using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Консольный калькулятор (Звездочка 1.0)");

                Console.WriteLine(@"Выберите арифметическое действие: 
             - Умножение (введите *) 
             - Деление (введите /) 
             - Сложение (введите +) 
             - Вычитание (введите -)");
                string s = Console.ReadLine();
                float a, b;
                Console.WriteLine(' ');
                Console.WriteLine("Введите первое число");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine(' ');
                if (s == "*")
                    Console.WriteLine("Результат умножения = {0}", a * b);
                if (s == "/")
                    Console.WriteLine("Результат деления ={0} ", a / b);
                if (s == "+")
                    Console.WriteLine("Результат сложения ={0} ", a + b);
                if (s == "-")
                    Console.WriteLine("Результат вычитания ={0} ", a - b);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
