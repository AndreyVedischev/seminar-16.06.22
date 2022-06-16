using System;
using static System.Console;


Clear();
Write("Введите число: ");
WriteLine($"Произведение чисел равно {Getn(Convert.ToInt32(ReadLine()))}");

int Getn(int n)
{
    int result = 1;                      //можно поставить Int 64 для больших чисел.
    for(int i = 1; i<=n; i++)
    {
        result*= i;
    }
    return result;
}
