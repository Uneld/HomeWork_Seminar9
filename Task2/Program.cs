﻿System.Console.Clear();
System.Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");