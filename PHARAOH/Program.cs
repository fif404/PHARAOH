﻿Console.WriteLine("Введите натуральное число:");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
{
    if ((x % i) == 0)
    {
        Console.Write(i + " ");
    }
}