/* Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
 */

 int x=1;
 Console.WriteLine("Введите число N ");
 int N=int.Parse(Console.ReadLine());
 while (x<=N)
 {
    Console.Write(Math.Pow(x,2)+" ");
    x++;
 }
