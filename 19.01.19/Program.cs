System.Console.WriteLine("--> ");

int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10000;


int c = a % 10;

if (a > 10000 && a < 100000) {

if (b == c) {
    System.Console.WriteLine("Палиндром");
}
else {
    System.Console.WriteLine("Не палиндром");
}
 }

 else {
    System.Console.WriteLine("Введите пятизначное число ");
 };
 

