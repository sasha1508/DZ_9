// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

System.Console.Write("Введи число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());

// При необходимости меняем M и N местами:
if(m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

int Sum(int m, int n)
{
    
    if(m == n) 
    {
        return n;
    }
    int sum = m + Sum(m+1, n);
    return sum;
}

string numbers = "";
System.Console.WriteLine(Sum(m, n));