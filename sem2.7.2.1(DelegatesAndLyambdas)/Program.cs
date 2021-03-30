using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2._7._2._1_DelegatesAndLambdas_
{
    class Program
    {
        delegate double Delegates(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послiдовно один за одним");
            Console.WriteLine("Поки вони не матимуть вигляд 0 х чи 1 х чи 2 х");
            Console.WriteLine("<тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа>, ");
            Console.WriteLine("програма обчислюватиме одну з трьох функцiй");
            Console.WriteLine("          0 -- sqrt(abs(x))");
            Console.WriteLine("          1 -- x^3 (x*x*x)");
            Console.WriteLine("          2 -- x+3.5");
            Console.WriteLine("(згiдно цифри на початку) i виводитиме результат.");
            Console.WriteLine("Якщо вхiдний рядок не задовольнятиме цей формат, програма завершить свою роботу.");
            Delegates[] methods = new Delegates[] { MethodZero, MethodOne, MethodTwo };
            while (true)
            {
                try
                {
                    int[] nums = Array.ConvertAll(Convert.ToString(Console.ReadLine()).Split(' '), int.Parse);
                    double output = methods[nums[0]](nums[1]);
                    Console.WriteLine(output);
                }
                catch (Exception)
                {
                    Console.WriteLine("Були введені некоректні дані. Формат введення: {число від 0 до 2} {будь-яке число}");
                    break;
                }
            }
            Console.ReadKey();
        }
        static double MethodZero(int x) => Math.Sqrt(Math.Abs(x));
        static double MethodOne(int x) => x * x * x;
        static double MethodTwo(int x) => x + 3.5;
    }
}
