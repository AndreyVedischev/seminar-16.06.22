using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
WriteLine(GetLength(number));

int GetLength(int num)
{
    int len = 0;
    for(int i = 1; i <=num; i *= 10)
    {
        len++;
    }
    return len;
}
