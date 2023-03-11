// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

System.Console.Write("Введи число M: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи число N: ");
int m = Convert.ToInt32(Console.ReadLine());

// При необходимости меняем знак у M и N:
if(m < 0) m *= -1;
if(n < 0) n *= -1;

int Akkerman(int n, int m)
{
    if(n == 0) return m+1;
    if(m == 0) return Akkerman(n - 1, 1);

    int akk = Akkerman(n-1, Akkerman(n, m-1)); 
    return akk;
}

System.Console.WriteLine(Akkerman(n, m));

