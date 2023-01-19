double max = 0;
double min = 0;

System.Console.WriteLine("Введите первое целое число ");
double a;
a = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите второе целое число ");

double b;
b = Convert.ToDouble(Console.ReadLine());

if (a > b) {
    max = a;
    min = b;
}
else {
    max = b;
    min = a;
};
System.Console.WriteLine("Максимальное число " + max);
System.Console.WriteLine("Минимальное число "+ min);
