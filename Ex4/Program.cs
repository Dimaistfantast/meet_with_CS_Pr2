﻿Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.Write("YES");
}
else
{
    Console.Write("NO");
}