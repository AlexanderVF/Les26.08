﻿Console.Clear();
Console.WriteLine("Введите X1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine("Растояние между точками в 3Д пространстве -> " + Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
