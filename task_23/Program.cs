﻿// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=0)
{
 Console.WriteLine("Введите n > 0");
}
else
{
    for (int i = 1; i <= n; i++) 
    Console.Write($"{Math.Pow(i, 3)}, ");
    Console.WriteLine(" ");
}

