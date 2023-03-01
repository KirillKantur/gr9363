// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Метод вывода данных пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
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
//Метод подсчета четных чисел массива
int EvenSum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res = res + 1;
        }

    }
    return res;
}

int[] arrTest = Gen1DArr(20,1,99);
Print1DArr(arrTest);
int sum = EvenSum(arrTest);
PrintData("Сумма четных чисел массива ", sum);
