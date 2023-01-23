//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("--> ");

int n = Convert.ToInt32(Console.ReadLine());

for (double i = 1; i <=n; i++) {

System.Console.WriteLine(Math.Pow(i, 3));
};
