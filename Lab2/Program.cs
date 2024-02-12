using Lab2;
using System;
using System.Numerics;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 2 - Наследование");
            Console.WriteLine("Сделал Timur Engalytchev");

            Rectangle a = new()
            {
                Name = "Прямоугольник А",
                Height = 13.7,
                Width = 15.2
            };
            Rectangle b = new()
            {
                Name = "Прямоугольник Б",
                Height = 2.8,
                Width = 5.1
            };

            Console.WriteLine();
            
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            
            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());

        }
    }
}