System.Console.WriteLine("--> ");

int a = Convert.ToInt32(Console.ReadLine());
int result;


if (a > 99 && a < 1000) {
    result = (a / 10) % 10;
    System.Console.WriteLine("Вторая цифра " + result);
}
else System.Console.WriteLine("Ошибка");