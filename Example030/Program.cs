﻿// //30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7)
// int a = new Random().Next(2)


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    { 
        result[i] = new Random().Next(2);
    }
    return result;
}
int[] array = GetBinaryArray(8);
Console.WriteLine($"{array[array.Length - 1]}");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
