﻿/* Программа, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.Write ("Таблица квадратов числа {N} = ");

for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i,2)} ");
}

// Console.WriteLine(Math.Pow(i,2)");
