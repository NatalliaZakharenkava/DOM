System.Console.WriteLine("Введите целое число ");

int n = Convert.ToInt32(Console.ReadLine());

if (n < 99) {
    System.Console.WriteLine("Третьей цифры нет");
}
else {
    while (n > 999) {
        n = n / 10;
    }
    System.Console.WriteLine("Третье число " + n % 10);
};


