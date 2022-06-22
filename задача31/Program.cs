using System;
using static System.Console;
Clear();

Write("Введите число: "); 
int n = int.Parse(ReadLine());
int [] array = GetRandomArray(n,0,2);
// string answer = String.Join(",", array);

// WriteLine($"[{answer}]");
PrintArray(array);
//WriteLine($"[{String.Join(",", array)}]");

void PrintArray(int[] array)
{
    Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]},");
    }
    Write($"{array[array.Length -1]}]");
}

int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //(0,2)
    }
    return result;
}