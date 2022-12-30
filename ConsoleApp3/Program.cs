using System;
namespace ConsoleWhile
{
    class Program
    {
        static void Main()
        {
            double a, x = 1.5, e = 0.0005, q = 0, s = 0;
            int n = 0;
            a = 1 / x;
            while (Math.Abs(a) > e)
            {
                a = Math.Pow(-1, n) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                s += a;
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("Сумма s = " + Convert.ToString(s));
            Console.WriteLine("Число членов ряда n = " + Convert.ToString(n));
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.ReadKey();
        }
    }
}
