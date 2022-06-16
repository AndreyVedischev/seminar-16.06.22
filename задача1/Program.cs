using System;
using static System.Console;

Clear();
WriteLine("Введите число: ");
int N = Convert.ToInt32(ReadLine());
WriteLine(GetCount(N));
int GetCount(int a)
{
    int result = 0;
    while (a > 1)
    {
        a = a / 10;
        result++;
    }
    return result;
}