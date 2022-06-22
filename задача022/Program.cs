using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
WriteLine($"Произведение чисел равно {Feban(Convert.ToInt32(ReadLine()))}");

Int64 Feban(int n)
{
    int result = 1;
    for(int i = 1; i <= n ; i++)
    {
        result *= i;
    }
    return result;

}