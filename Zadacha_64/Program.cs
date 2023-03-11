﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
System.Console.Write("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(string numbers, int n)
{
    if(n == 1) 
    {
        numbers = "1";
        return numbers;
    }
    numbers = n + ", " + PrintNumbers(numbers, n-1);
    return numbers;
}

string numbers = "";
System.Console.WriteLine(PrintNumbers(numbers, n));