System.Console.WriteLine("Введите цифру от 1 до 7 ");

int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && n <= 5) {
    System.Console.WriteLine("Будний день!");
}
else if (n >= 6 && n <= 7) {
    System.Console.WriteLine("Выходной!");
}
else {
    System.Console.WriteLine("Неверная цифра, попробуйте снова");
};


