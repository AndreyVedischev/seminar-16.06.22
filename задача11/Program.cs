using System;
using static System.Console;

Clear();
WriteLine("Введите число: ");
//int N = Convert.ToInt32(ReadLine());
WriteLine($"Количество цыфр = {GetCount(Convert.ToInt32(ReadLine()))}");

int GetCount(int a)
{
    int result = 0;
    for(int i = 0;i < a; i++)
    {
        a = a / 10;
        result++;
    }
    return result;
}
