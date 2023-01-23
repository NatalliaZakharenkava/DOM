/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве */

System.Console.WriteLine("Введите координаты точки А: ");

int x1 = Convert.ToInt32(Console.ReadLine());

int y1 = Convert.ToInt32(Console.ReadLine());

int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B: ");

int x2 = Convert.ToInt32(Console.ReadLine());

int y2 = Convert.ToInt32(Console.ReadLine());

int z2 = Convert.ToInt32(Console.ReadLine());

double S = (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

double Distance = Math.Sqrt(S);

System.Console.WriteLine("Расстояние A --> B равно " + Distance);
