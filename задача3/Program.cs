using System;
using static System.Console;
Clear();

int [] array = new int[20];
FilArray(array);
PrintArray(array);

void FilArray(int[] collection)
{
    int index = 0;
    for(int i = 0; i < collection.Length; i++)
    {
        collection[index] = new Random().Next(1,8);
        index++;
    }
}

void PrintArray(int[] col)

{
    int position = 0;
    for(int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}