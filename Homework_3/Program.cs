/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

/* Console.WriteLine("Введите 5-ти значное число ");
int x = int.Parse(Console.ReadLine());

int a1 = x / 10000;
int a2 = x % 10;
int b1 = (x % 10000) / 1000;
int b2 = (x / 10) % 10;

if (a1 == a2 && b1 == b2)
{
    Console.WriteLine("Да, число является палиндромом ");
}
else
{
    Console.WriteLine("Нет, не является палиндромом");
}
 */

///////////////////////////////////////////////////////////////////////////////////////////////
/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координату x1 для точки А ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1 для точки А ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z1 для точки А ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2 для точки B ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2 для точки B ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z2 для точки B ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine("A (" + x1 + "," + y1 + "," + z1 + ")");
Console.WriteLine("B (" + x2 + "," + y2 + "," + z2 + ")");

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine("Расстояние между точками в 3D: " + Math.Round(result, 2));

////////////////////////////////////////////////////////////////////////////////////////////////
/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */