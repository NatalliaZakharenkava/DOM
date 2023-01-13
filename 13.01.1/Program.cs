int max = 0;
int min = 0;

System.Console.WriteLine("Введите первое целое число ");

int a;
a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе целое число ");

int b;
b = Convert.ToInt32(Console.ReadLine());

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
