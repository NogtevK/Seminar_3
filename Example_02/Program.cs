/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
 */

Console.WriteLine("Введите номер плоскости от 1 до 4");
int X = int.Parse(Console.ReadLine());

if (X == 1)
{
    Console.WriteLine("Диапазон координат X>0;Y>0");
}
else if (X == 2)
{
    Console.WriteLine("Диапазон координат X<0;Y>0");
}
else if (X == 3)
{
    Console.WriteLine("Диапазон координат X<0;Y<0");
}
else if (X == 4)
{
    Console.WriteLine("Диапазон координат X>0;Y<0");
}
else if (X < 1 || X > 4)
{
    Console.WriteLine("Нет координат для данной плоскости");
}