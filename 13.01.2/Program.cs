int max = 0;

System.Console.WriteLine("Введите первое целое число ");

int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе целое число ");

int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье целое число ");

int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) {
    max = a;
}
if (b > a && b > c) {
    max = b;
}
else {
    max = c;
};

System.Console.WriteLine("Максимальное целое число " + max);

