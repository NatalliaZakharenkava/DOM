﻿System.Console.WriteLine("Введите координаты точки А: ");

int x1 = Convert.ToInt32(Console.ReadLine());

int y1 = Convert.ToInt32(Console.ReadLine());

int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B: ");

int x2 = Convert.ToInt32(Console.ReadLine());

int y2 = Convert.ToInt32(Console.ReadLine());

int z2 = Convert.ToInt32(Console.ReadLine());

double S = (((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));

double S1 = Math.Sqrt(S);

System.Console.WriteLine("Расстояние A-B равно " + S1);
