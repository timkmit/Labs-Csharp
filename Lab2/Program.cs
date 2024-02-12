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

            Console.WriteLine("1---------------");

            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            
            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());

            Circle ac = new()
            {
                Name = "Круг АС",
                Height = 2,
                Width = 3
            };
            Circle bc = new()
            {
                Name = "Круг БС",
                Height = 4,
                Width = 5
            };

            Console.WriteLine();

            Console.WriteLine("2---------------");

            Console.WriteLine("Название фигуры: {0}", ac.Name);
            Console.WriteLine("Площадь фигуры: {0}", ac.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", bc.Name);
            Console.WriteLine("Площадь фигуры: {0}", bc.GetArea());


            Trapezoid at = new()
            {
                Name = "Трапеция АТ",
                Height = 2,
                Width = 3
            };
            Trapezoid bt = new()
            {
                Name = "Трапеция БТ",
                Height = 4,
                Width = 5
            };

            Console.WriteLine();

            Console.WriteLine("3---------------");

            Console.WriteLine("Название фигуры: {0}", at.Name);
            Console.WriteLine("Площадь фигуры: {0}", at.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", bt.Name);
            Console.WriteLine("Площадь фигуры: {0}", bt.GetArea());


        }
    }
}