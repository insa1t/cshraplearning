﻿Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int i = 2;
while (i <= num)
{
    Console.Write($"{i} ");
    i = i+2;
}