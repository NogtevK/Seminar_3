/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

Console.WriteLine("Введите X:");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y:");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая плоскость");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая плоскость");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья плоскость");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвёртая плоскость");
}else
{
    Console.WriteLine("Не принадлежит ни одной плоскости");
}