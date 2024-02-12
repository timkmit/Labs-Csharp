﻿using Lab2;
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
                Name = "Круг 1",
                Radius = 10,
            };
            Circle bc = new()
            {
                Name = "Круг 2",
                Radius = 9,
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
                Name = "Трапеция 1",
                Height = 2,
                Side = 3,
                Side2 = 4,
            };
            Trapezoid bt = new()
            {
                Name = "Трапеция 2",
                Height = 4,
                Side = 5,
                Side2 = 4,
            };

            Console.WriteLine();

            Console.WriteLine("3---------------");

            Console.WriteLine("Название фигуры: {0}", at.Name);
            Console.WriteLine("Площадь фигуры: {0}", at.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", bt.Name);
            Console.WriteLine("Площадь фигуры: {0}", bt.GetArea());


            Rhomb ar = new()
            {
                Name = "Ромб 1",
                Height = 2,
                Side = 3
            };
            Rhomb br = new()
            {
                Name = "Ромб 2",
                Height = 4,
                Side = 5
            };

            Console.WriteLine();

            Console.WriteLine("4---------------");

            Console.WriteLine("Название фигуры: {0}", ar.Name);
            Console.WriteLine("Площадь фигуры: {0}", ar.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", br.Name);
            Console.WriteLine("Площадь фигуры: {0}", br.GetArea());


            Parallelogram ap = new()
            {
                Name = "Параллелограм 1",
                Height = 2,
                Side = 7
            };
            Parallelogram bp = new()
            {
                Name = "Параллелограм 2",
                Height = 4,
                Side = 6
            };

            Console.WriteLine();

            Console.WriteLine("5---------------");

            Console.WriteLine("Название фигуры: {0}", ap.Name);
            Console.WriteLine("Площадь фигуры: {0}", ap.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", bp.Name);
            Console.WriteLine("Площадь фигуры: {0}", bp.GetArea());


            Pentagon pent1 = new()
            {
                Name = "Правильный пятиугольник 1",
                Radius = 2,
                Side = 3
            };
            Pentagon pent2 = new()
            {
                Name = "Правильный пятиугольник 2",
                Radius = 4,
                Side = 5
            };

            Console.WriteLine();

            Console.WriteLine("6---------------");

            Console.WriteLine("Название фигуры: {0}", pent1.Name);
            Console.WriteLine("Площадь фигуры: {0}", pent1.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", pent2.Name);
            Console.WriteLine("Площадь фигуры: {0}", pent2.GetArea());


            Decagon dec1 = new()
            {
                Name = "Правильный десятиугольник 1",
                Radius = 2,
                Side = 3
            };
            Decagon dec2 = new()
            {
                Name = "Правильный десятиугольник 2",
                Radius = 4,
                Side = 5
            };

            Console.WriteLine();

            Console.WriteLine("7---------------");

            Console.WriteLine("Название фигуры: {0}", dec1.Name);
            Console.WriteLine("Площадь фигуры: {0}", dec1.GetArea());

            Console.WriteLine();

            Console.WriteLine("Название фигуры: {0}", dec2.Name);
            Console.WriteLine("Площадь фигуры: {0}", dec2.GetArea());


        }
    }
}