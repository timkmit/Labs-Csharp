using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAb 1");
            Console.WriteLine("MAde Timur Engalytchev");

            Complex a = new() { Real = 3, Imag = 0.5 };
            Complex b = new() { Real = 2, Imag = 0.8 };

            a.Add(b);

            b.Subtract(a);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
        }
    }
}