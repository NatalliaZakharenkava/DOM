System.Console.WriteLine("Введите целое число ");

int N = Convert.ToInt32(Console.ReadLine());

int a = 2;
 if (N > 1) {
    while (a <= N) {
        System.Console.Write(a + " ");
        a = a + 2;
    }
}