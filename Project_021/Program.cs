﻿// Задача 22: Найти расстояние между точками в пространстве 3D

Console.Clear();

double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}


Console.Write("Введите координату x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = double.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Distance3D(x1, y1, z1, x2, y2, z2) + ".");

