// Задача No55
// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.


// Метод генерации 2Д массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
//Метод печати 2Д массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


// Метод транспорирования
void TraspArr(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

int[,] testArr = Gen2DArr(10, 10, 1, 10);
Print2DArr(testArr);
if (testArr.GetLength(0) == testArr.GetLength(1))
{
    TraspArr(testArr);
    Print2DArr(testArr);
}
else
{
    Console.WriteLine("Действие невозможно");
}
