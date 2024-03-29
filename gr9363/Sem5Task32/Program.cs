﻿// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// Метод генерации массива
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    // Блок корректировкивходных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
}
// Метод печати масива
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод инверсии массива
void InversArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);