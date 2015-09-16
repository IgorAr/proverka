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
            Console.WriteLine("Консольный калькулятор (Звездочка 1.0)");
            var salmons = new List<string>();
            salmons.Add("sum");
            salmons.Add("sub");
            salmons.Add("mult");
            salmons.Add("div");

            while (true)
            {
                Console.WriteLine(@"sum [sub,div,mult] a b");

                string s = Console.ReadLine();
                string[] split = s.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // CHECK user input
                if (split.Length != 3)
                {
                    Console.WriteLine("You inputed too many symbols, see input format");
                    continue;
                }
                if (!salmons.Contains(split[0]))
                {
                    Console.WriteLine("Please input correct operation");
                    continue;
                };

                float a;
                bool result1 = float.TryParse(split[1], out a);
                if (!(result1))
                {
                    Console.WriteLine(split[1] + " is not a number");
                    continue;
                }
                float b;
                bool result2 = float.TryParse(split[2], out b);
                if (!(result2))
                {
                    Console.WriteLine(split[2] + " is not a number");
                    continue;
                }
                //Output and calculating

                switch (split[0])
                {
                    case "mult":
                        Console.WriteLine("Результат умножения = {0}", a * b);
                        break;
                    case "div":
                        if (b == 0)
                        {
                            Console.WriteLine("Division by zero");
                        }
                        else
                        {
                            Console.WriteLine("Результат деления ={0} ", a / b);
                        }
                        break;
                    case "sum":
                        Console.WriteLine("Результат сложения ={0} ", a + b);
                        break;
                    case "sub":
                        Console.WriteLine("Результат вычитания ={0} ", a - b);
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
