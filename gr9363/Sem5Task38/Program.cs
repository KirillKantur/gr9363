// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

//Метод вывода данных пользователя
void PrintData(string line, double num)
{
    Console.WriteLine(line + num);
}

// Метод генерации массива вещественных чисел
double[] Gen1DArr(int len, int minValue, int maxValue)
{
    // Блок корректировкивходных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    Double[] arr = new Double[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue) + rnd.NextDouble();
    }
    return arr;
}

// Метод печати масива
void Print1DArr(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод нахождения разницы существенных чисел в массиве
double MaxMin(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

double[] arrTest = Gen1DArr(20,1,10);
Print1DArr(arrTest);
double res =MaxMin(arrTest);
PrintData("Разницу между максимальным и минимальным элементом массива ",res);